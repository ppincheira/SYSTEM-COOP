﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implement;
using Model;
using System.Data;

namespace Business
{
    public class LecturasSuministrosBus
    {

        public long LecturasSuministrosAdd(LecturasSuministros oLecSum)
        {
            LecturasSuministrosImpl oLecSumImpl = new LecturasSuministrosImpl();
            return oLecSumImpl.LecturasSuministrosAdd(oLecSum);
        }

        public bool LecturasSuministrosUpdate(LecturasSuministros oLecSum)
        {
            LecturasSuministrosImpl oLecSumImpl = new LecturasSuministrosImpl();
            return oLecSumImpl.LecturasSuministrosUpdate(oLecSum);
        }

        public bool LecturasSuministrosDelete(long Id)
        {
            LecturasSuministrosImpl oLecSumImpl = new LecturasSuministrosImpl();
            return oLecSumImpl.LecturasSuministrosDelete(Id);
        }

        public LecturasSuministros LecturasSuministrosGetById(long Id)
        {
            LecturasSuministrosImpl oLecSumImpl = new LecturasSuministrosImpl();
            return oLecSumImpl.LecturasSuministrosGetById(Id);
        }

        public List<LecturasSuministros> LecturasSuministrosGetAll()
        {
            LecturasSuministrosImpl oLecSumImpl = new LecturasSuministrosImpl();
            return oLecSumImpl.LecturasSuministrosGetAll();
        }


        public DataTable LecturasSuministrosGetByIdSuministro(long Id, string Periodo, string EstadosLecturas)
        {
            LecturasSuministrosImpl oLecSumImpl = new LecturasSuministrosImpl();
            return oLecSumImpl.LecturasSuministrosGetByIdSuministro(Id, Periodo, EstadosLecturas);
        }
    }
}
