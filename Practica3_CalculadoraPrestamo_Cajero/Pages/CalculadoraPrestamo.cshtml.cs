using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practica3_CalculadoraPrestamo_Cajero.Pages
{
    public class CalculadoraPrestamoModel : PageModel
    {
        public double CuotaMensual { get; set; }

        public void OnGet(double MontoPrestamo, int CantidadCuotas, double PorcentajeInteres)
        {
            this.CuotaMensual = MontoPrestamo * (1 + (((CantidadCuotas / 12) * PorcentajeInteres) / 100)) / (CantidadCuotas);
        }
    }
}
