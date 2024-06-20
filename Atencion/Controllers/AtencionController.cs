<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Atencion.Models;
using Microsoft.AspNetCore.Mvc;
/*
using System.Data;
using System.Data.SqlClient;
*/

namespace Atencion.Controllers
{
    public class AtencionController : Controller
    {
        //private string connectionString = "String de conexion a la BD";
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FechaInicio = DateTime.Now.ToString("yyyy-MM-dd");
            ViewBag.FechaFin = DateTime.Now.ToString("yyyy-MM-dd");

            var clientes = GetData();
            return View(clientes);
        }


        [HttpPost]
        public IActionResult Index(string daterange)
        {
            var fechas = daterange.Split('-');
            var fechaInicial = DateTime.ParseExact(fechas[0].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            var fechaFinal = DateTime.ParseExact(fechas[1].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            ViewBag.FechaInicio = fechaInicial.ToString("yyyy-MM-dd");
            ViewBag.FechaFin = fechaFinal.ToString("yyyy-MM-dd");

            var clientesTodos = GetData();
            var clientes = clientesTodos.Where(c => c.FechaAlta >= fechaInicial && c.FechaAlta <= fechaFinal).ToList();
            /*
            List<string> resultados = new List<string>();
            string consultaSql = "SELECT * FROM ATENCION_CLIENTE WHERE (FECHA_ALTA BETWEEN @ValorParametro1 AND @ValorParametro2)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(consultaSql, conexion);
                comando.Parameters.AddWithValue("@ValorParametro1", fechaInicial);
                comando.Parameters.AddWithValue("@ValorParametro2", fechaFinal);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Cliente registro = new Cliente{
                            id = Convert.ToInt32(reader["ID"]),
                            Nombre = reader["NOMBRE"].ToString(),
                            Apellidos = reader["APELLIDOS"].ToString(),
                            Celular = reader["CELULAR"].ToString(),
                            Email = reader["EMAIL"].ToString(),
                            Sexo = reader["SEXO"].ToString(),
                            Motivo = reader["MOTIVO"].ToString(),
                            FechaAlta = reader["FECHA_ALTA"].ToString(),
                        }
                        resultados.Add(registro);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                }
            }
            return View(resultados); // Puedes pasar los resultados a la vista
            */

            return View(clientes);
        }


        public List<Cliente> GetData()
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente { id = 1, Nombre = "Natalia", Apellidos = "Meneses", Celular = "111111", Email = "natalia@gmail.com", Sexo = "Mujer", Motivo = "Incidencia", FechaAlta = DateTime.ParseExact("16/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture) });
            clientes.Add(new Cliente { id = 1, Nombre = "Carolina", Apellidos = "Ramirez", Celular = "222222", Email = "carolina@gmail.com", Sexo = "Mujer", Motivo = "Reclamación", FechaAlta = DateTime.ParseExact("17/07/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture) });
            clientes.Add(new Cliente { id = 1, Nombre = "Andres", Apellidos = "Corredor", Celular = "333333", Email = "andres@gmail.com", Sexo = "Hombre", Motivo = "Reclamación", FechaAlta = DateTime.ParseExact("18/08/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture) });
            clientes.Add(new Cliente { id = 1, Nombre = "Lorena", Apellidos = "Salazar", Celular = "444444", Email = "lorena@gmail.com", Sexo = "Mujer", Motivo = "Queja", FechaAlta = DateTime.ParseExact("19/09/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture) });
            clientes.Add(new Cliente { id = 1, Nombre = "Eduardo", Apellidos = "Andrade", Celular = "555555", Email = "eduardo@gmail.com", Sexo = "Hombre", Motivo = "Sugerencia", FechaAlta = DateTime.ParseExact("20/10/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture) });
            return clientes;
        }

        public IActionResult Create()
        {
            return View();
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Atencion.Models;
using Microsoft.AspNetCore.Mvc;
/*
using System.Data;
using System.Data.SqlClient;
*/

namespace Atencion.Controllers
{
    public class AtencionController : Controller
    {
        //private string connectionString = "String de conexion a la BD";
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FechaInicio = DateTime.Now.ToString("yyyy-MM-dd");
            ViewBag.FechaFin = DateTime.Now.ToString("yyyy-MM-dd");

            var clientes = GetData();
            return View(clientes);
        }


        [HttpPost]
        public IActionResult Index(string daterange)
        {
            var fechas = daterange.Split('-');
            var fechaInicial = DateTime.ParseExact(fechas[0].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            var fechaFinal = DateTime.ParseExact(fechas[1].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            ViewBag.FechaInicio = fechaInicial.ToString("yyyy-MM-dd");
            ViewBag.FechaFin = fechaFinal.ToString("yyyy-MM-dd");

            var clientesTodos = GetData();
            var clientes = clientesTodos.Where(c => c.FechaAlta >= fechaInicial && c.FechaAlta <= fechaFinal).ToList();
            /*
            List<string> resultados = new List<string>();
            string consultaSql = "SELECT * FROM ATENCION_CLIENTE WHERE (FECHA_ALTA BETWEEN @ValorParametro1 AND @ValorParametro2)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(consultaSql, conexion);
                comando.Parameters.AddWithValue("@ValorParametro1", fechaInicial);
                comando.Parameters.AddWithValue("@ValorParametro2", fechaFinal);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Cliente registro = new Cliente{
                            id = Convert.ToInt32(reader["ID"]),
                            Nombre = reader["NOMBRE"].ToString(),
                            Apellidos = reader["APELLIDOS"].ToString(),
                            Celular = reader["CELULAR"].ToString(),
                            Email = reader["EMAIL"].ToString(),
                            Sexo = reader["SEXO"].ToString(),
                            Motivo = reader["MOTIVO"].ToString(),
                            FechaAlta = reader["FECHA_ALTA"].ToString(),
                        }
                        resultados.Add(registro);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                }
            }
            return View(resultados); // Puedes pasar los resultados a la vista
            */

            return View(clientes);
        }


        public List<Cliente> GetData()
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente { id = 1, Nombre = "Natalia", Apellidos = "Meneses", Celular = "111111", Email = "natalia@gmail.com", Sexo = "Mujer", Motivo = "Incidencia", FechaAlta = DateTime.ParseExact("16/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture) });
            clientes.Add(new Cliente { id = 1, Nombre = "Carolina", Apellidos = "Ramirez", Celular = "222222", Email = "carolina@gmail.com", Sexo = "Mujer", Motivo = "Reclamación", FechaAlta = DateTime.ParseExact("17/07/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture) });
            clientes.Add(new Cliente { id = 1, Nombre = "Andres", Apellidos = "Corredor", Celular = "333333", Email = "andres@gmail.com", Sexo = "Hombre", Motivo = "Reclamación", FechaAlta = DateTime.ParseExact("18/08/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture) });
            clientes.Add(new Cliente { id = 1, Nombre = "Lorena", Apellidos = "Salazar", Celular = "444444", Email = "lorena@gmail.com", Sexo = "Mujer", Motivo = "Queja", FechaAlta = DateTime.ParseExact("19/09/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture) });
            clientes.Add(new Cliente { id = 1, Nombre = "Eduardo", Apellidos = "Andrade", Celular = "555555", Email = "eduardo@gmail.com", Sexo = "Hombre", Motivo = "Sugerencia", FechaAlta = DateTime.ParseExact("20/10/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture) });
            return clientes;
        }

        public IActionResult Create()
        {
            return View();
        }
    }
>>>>>>> f8566ec (Tercera carga)
}