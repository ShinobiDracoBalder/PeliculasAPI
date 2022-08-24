using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace PeliculasAPI.Common.Helpers
{
    public static class HttpContextExtensions
    {
        public async static Task InsertarParametrosPaginacion<T>(this HttpContext httpContext,
            IQueryable<T> queryable, int cantidadRegistrosPorPagina)
        {
            double cantidad = await queryable.CountAsync();
            double cantidadPaginas = Math.Ceiling(cantidad / cantidadRegistrosPorPagina);
            httpContext.Response.Headers.Add("cantidadPaginas", cantidadPaginas.ToString());
        }

    }
}
