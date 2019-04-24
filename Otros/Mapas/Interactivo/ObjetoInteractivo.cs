﻿using System;
using System.Linq;
using System.Xml.Linq;

namespace Bot_Dofus_1._29._1.Otros.Mapas.Interactivo
{
    public class ObjetoInteractivo
    {
        public short gfx { get; private set; }
        public ObjetoInteractivoModelo modelo { get; private set; }
        public bool es_utilizable { get; set; } = false;

        public ObjetoInteractivo(short _gfx)
        {
            gfx = _gfx;

            ObjetoInteractivoModelo _modelo = ObjetoInteractivoModelo.get_Modelo_Por_Gfx(gfx);
            if (_modelo != null)
            {
                modelo = _modelo;
                
                es_utilizable = true;
            }
        }
    }
}
