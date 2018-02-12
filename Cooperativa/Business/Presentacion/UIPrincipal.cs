using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.Presentacion
{
    public class UIPrincipal
    {
        private  IVistaPrincipal _vista;
        private MenuItemsBus oMenuItem;

        public void InicializarArbol() {
            CrearNodosDelPadre(-1, null);
        }

        public void CrearNodosDelPadre(int indicePadre, TreeNode nodePadre)
        {
            MenuItemsBus oMenuBus = new MenuItemsBus();

            DataTable dt = oMenuBus.MenuItemsGetByIdCodigo("0001");
            // Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.
            DataView dataViewHijos = new DataView(dt);
            dataViewHijos.RowFilter = dt.Columns["MNI_CODIGO_PADRE"].ColumnName + " = " + indicePadre;

            // Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
            foreach (DataRowView dataRowCurrent in dataViewHijos)
            {
                TreeNode nuevoNodo = new TreeNode();
                nuevoNodo.Text = dataRowCurrent["FRM_NOMBRE"].ToString().Trim();

                // si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
                // del primer nivel que no dependen de otro nodo.
                if (nodePadre == null)
                {
                    _vista.oTreeNode.Nodes.Add(nuevoNodo);
                }
                // se añade el nuevo nodo al nodo padre.
                else
                {
                    nodePadre.Nodes.Add(nuevoNodo);
                }

                // Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.

                CrearNodosDelPadre(Int32.Parse(dataRowCurrent["MNI_CODIGO"].ToString()), nuevoNodo);
            }
        }
    }
}
