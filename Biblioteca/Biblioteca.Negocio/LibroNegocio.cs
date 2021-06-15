﻿using Biblioteca.Datos.Mappers;
using Biblioteca.Entidades;
using Biblioteca.Entidades.exceptions;
using Biblioteca.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class LibroNegocio
    {
        LibroMapper _libroMapper;

        public LibroNegocio()
        {
            _libroMapper = new LibroMapper();
        }

        public TransactionResult insertarLibro(string edicion, string paginas, string titulo, string autor, string editorial, string tema)
        {
            try
            {
                Random random = new Random();
                Libro libro = new Libro();
                libro.Id = random.Next(50);
                libro.Edicion = int.Parse(edicion);
                libro.Paginas = int.Parse(paginas);
                libro.Titulo = titulo;
                libro.Autor = autor;
                libro.Editorial = editorial;
                libro.Tema = tema;

                return _libroMapper.insertarLibro(libro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<Libro> traerTodos()
        {
            try
            {
                return _libroMapper.traerTodos();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}