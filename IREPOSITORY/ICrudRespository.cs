﻿using REQUESTRESPONSEMODEL;

namespace IREPOSITORY
{
    /// <summary>
    /// DISPONE DE TODOS LOS METODOS DEL CRUD
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICrudRepository<T> : IDisposable
    {
        /// <summary>
        /// RETORNA TODA LA LISTA DE LA TABLA <typeparamref name="T"/>
        /// </summary>
        /// <returns> LISTA DE <typeparamref name="T"/> </returns>
        List<T> GetAll();

        /// <summary>
        /// RETORNA UN REGISTRO DE LA TABLA FILTRADO POR EL PRIMARY KEY
        /// </summary>
        /// <param name="id">Primary key</param>
        /// <returns> <typeparamref name="T"/> </returns>
        T GetById(object id);
        /// <summary>
        /// INSERTA UN REGISTRO A LA TABLA <typeparamref name="T"/>
        /// </summary>
        /// <param name="entity"> <typeparamref name="T"/> </param>
        /// <returns> <typeparamref name="T"/> </returns>
        T Create(T entity);
        /// <summary>
        /// ACTUALIZA UN REGISTRO A LA TABLA <typeparamref name="T"/>
        /// </summary>
        /// <param name="entity"> <typeparamref name="T"/> </param>
        /// <returns> <typeparamref name="T"/> </returns>
        T Update(T entity);

        /// <summary>
        /// ELIMINA UN REGISTRO DE LA TABLA FILTRADO POR EL PRIMARY KEY
        /// </summary>
        /// <param name="id">primary key</param>
        /// <returns>int</returns>
        int Delete(object id);

        /// <summary>
        /// Elimina varios registros de la tabla
        /// </summary>
        /// <param name="lista"> List<paramref name="lista"/> </param>
        /// <returns>int cantidad de registros eliminados</returns>
        int DeleteMultipleItems(List<T> lista);

        /// <summary>
        /// inserta varios registros en la tabla <typeparamref name="T"/>
        /// </summary>
        /// <param name="lista"> List<paramref name="lista"/> </param>
        /// <returns>List<paramref name="lista"/></returns>
        List<T> CreateMultiple(List<T> lista);

        /// <summary>
        /// actualizar varios registros en la tabla <typeparamref name="T"/>
        /// </summary>
        /// <param name="lista"> List<paramref name="lista"/> </param>
        /// <returns>List<paramref name="lista"/></returns>
        List<T> UpdateMultiple(List<T> lista);
        GenericFilterResponse<T> GetByFilter(GenericFilterRequest request);
    }
    
}
