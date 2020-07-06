using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiVeterinaria.Web.Data.Entities
{
    public class SeedDb
    {

        private readonly DataContext _context;
        public SeedDb(DataContext context)
        {
            _context = context;
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
        }
        private async Task CheckTipoServiciosAsync()
        {
            if(!_context.TipoServicios.Any())
            {
                _context.TipoServicios.Add(new TipoServicio { nombre = "Consulta" });
                _context.TipoServicios.Add(new TipoServicio { nombre = "Urgencia" });
                _context.TipoServicios.Add(new TipoServicio { nombre = "Vacunación" });
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckTipoMascotasAsync()
        {
            if (!_context.TipoMascotas.Any())
            {
                _context.TipoMascotas.Add(new TipoMascota { nombre = "Perro" });
                _context.TipoMascotas.Add(new TipoMascota { nombre = "Gato" });
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckPropietariosAsync()
        {
            if (!_context.Propietarios.Any())
            {
                AddPropietario("31258963", "Juan", "Soto", "234 3232", "341 5453221", "Calle Mitre 1111");
                AddPropietario("6321456", "Jose", "Cardona", "343 3226", "3476 508701", "Calle Belgrano 112");
                AddPropietario("6565897", "Maria", "Lopez", "450 4332", "341 151515", "Jose Ingeniero 123");
                await _context.SaveChangesAsync();
            }
        }
        private void AddPropietario(string documento, string nombre, string apellido, string telFijo, string telCelular, string direccion)
        {
            _context.Propietarios.Add(new Propietario
            {
                Direccion = direccion,
                TelCelular = telCelular,
                Documento = documento,
                Nombre = nombre,
                TelFijo = telFijo,
                Apellido = apellido
            });
        }
        private async Task CheckMascotasAsync()
        {
            var propietario = _context.Propietarios.FirstOrDefault();
            var tipoMascota = _context.TipoMascotas.FirstOrDefault();
            if (!_context.Mascotas.Any())
            {
                AddMascota("Otto", propietario, tipoMascota, "Shih Tzu");
                AddMascota("Killer", propietario, tipoMascota, "Dobermann");
                await _context.SaveChangesAsync();
            }
        }
        private void AddMascota (string name, Propietario propietario, TipoMascota tipoMascota, string race)
        {
            _context.Mascotas.Add(new Mascota
            {
                Nacimiento = DateTime.Now.AddYears(-2),
                Nombre = name,
                Propietario = propietario,
                TipoMascota = tipoMascota,
                Raza = race
            });
        }
        private async Task CheckAgendasAsync()
        {
            if (!_context.Agendas.Any())
            {
                var initialDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
                var finalDate = initialDate.AddYears(1);
                while (initialDate < finalDate)
                {
                    if (initialDate.DayOfWeek != DayOfWeek.Sunday)
                    {
                        var finalDate2 = initialDate.AddHours(10);
                        while (initialDate < finalDate2)
                        {
                            _context.Agendas.Add(new Agenda
                            {
                                Fecha = initialDate.ToUniversalTime(),
                                EstaDisponible = true
                            });

                            initialDate = initialDate.AddMinutes(30);
                        }

                        initialDate = initialDate.AddHours(14);
                    }
                    else
                    {
                        initialDate = initialDate.AddDays(1);
                    }
                }

                await _context.SaveChangesAsync();
            }
        }
    }
}
