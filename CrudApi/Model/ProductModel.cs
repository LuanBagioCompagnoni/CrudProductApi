﻿using System.ComponentModel.DataAnnotations;

namespace CrudApi.Model
{
    public class ProductModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório!"), MaxLength(150, ErrorMessage = "O tamanho máximo do campo nome é 60")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Preço é obrigatório!")]
        public double Price { get; set; }

    }
}
