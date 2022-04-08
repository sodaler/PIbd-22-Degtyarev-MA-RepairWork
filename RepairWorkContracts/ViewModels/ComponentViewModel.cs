using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairWorkContracts.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class ComponentViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название ингредиента")]
        public string IngredientName { get; set; }
    } 
}
