using System.Collections.Generic;
using Implement;
using Model;


namespace Business
{
    public class ParametrosGeneralesBus
    {

        public int ParametrosGeneralesAdd(ParametrosGenerales oParametrosGenerales)
        {
            ParametrosGeneralesImpl oParametrosGeneralesImpl = new ParametrosGeneralesImpl();
            return oParametrosGeneralesImpl.ParametrosGeneralesAdd(oParametrosGenerales);
        }

        public bool ParametrosGeneralesUpdate(ParametrosGenerales oParametrosGenerales)
        {
            ParametrosGeneralesImpl oParametrosGeneralesImpl = new ParametrosGeneralesImpl();
            return oParametrosGeneralesImpl.ParametrosGeneralesUpdate(oParametrosGenerales);
        }

        public bool ParametrosGeneralesDelete(string Codigo, string Tipo)
        {
            ParametrosGeneralesImpl oParametrosGeneralesImpl = new ParametrosGeneralesImpl();
            return oParametrosGeneralesImpl.ParametrosGeneralesDelete(Codigo, Tipo);
        }

        public ParametrosGenerales ParametrosGeneralesGetById(string Codigo, string Tipo)
        {
            ParametrosGeneralesImpl oParametrosGeneralesImpl = new ParametrosGeneralesImpl();
            return oParametrosGeneralesImpl.ParametrosGeneralesGetById(Codigo, Tipo);
        }

        public List<ParametrosGenerales> ParametrosGeneralesGetAll()
        {
            ParametrosGeneralesImpl oParametrosGeneralesImpl = new ParametrosGeneralesImpl();
            return oParametrosGeneralesImpl.ParametrosGeneralesGetAll();
        }
    }
}
