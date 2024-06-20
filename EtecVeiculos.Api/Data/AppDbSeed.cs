using EtecVeiculos.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EtecVeiculos.Api.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder modelBuilder)
    {
        #region TipoVeiculo
        List<TipoVeiculo> tipoVeiculos = [
            new() {
                Id = 1,
                Nome = "Moto"
            },
            new() {
                Id = 2,
                Nome = "Carro"
            },
            new() {
                Id = 3,
                Nome = "Caminhão"
            }
        ];
        modelBuilder.Entity<TipoVeiculo>().HasData(tipoVeiculos);
        #endregion

        #region Marcas
        // Incluir 3 marcas
        List<Marca> marcas = new()
        {
            new()
            {
                Id = 1,
                Nome = "Volkswagen"
            },
            new()
            {
                Id = 2,
                Nome = "Ford"
            },
            new()
            {
                Id = 3,
                Nome = "Fiat"
            }
        };
        #endregion

        #region Modelo
        // Incluir 2 modelos por marca
        List<Modelo> modelos = new()
        {
            new()
            {
                Id = 1,
                Nome = "Fusca",
                MarcaId = 1
            },
            new()
            {
                Id = 2,
                Nome = "Kombi",
                MarcaId = 1
            },
            new()
            {
                Id = 3,
                Nome = "EcoSport",
                MarcaId = 2
            },
            new()
            {
                Id = 4,
                Nome = "Fusion",
                MarcaId = 2
            },
            new()
            {
                Id = 5,
                Nome = "Uno",
                MarcaId = 3
            },
            new()
            {
                Id = 6,
                Nome = "Fiorino",
                MarcaId = 3
            }
        };
        modelBuilder.Entity<Modelo>().HasData(modelos);
        #endregion
    }
}
