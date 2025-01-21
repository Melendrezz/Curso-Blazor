using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor5dotnet.ViewModel;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;

namespace blazor5dotnet.Pages.Counter
{

    public partial class Counter : ComponentBase
    {

        [Inject]
        CounterViewModel vm{get;set;}
        
        [Inject]
        IToastService toastService{get;set;}
        private void IncrementCount()
        {
            logger.LogInformation($"Incrementando Count en 1 {vm.currentCount}");
            vm.currentCount++;
            logger.LogInformation($"Valor de Count incremento {vm.currentCount}");

            toastService.ShowSuccess("Se incremento en uno");
        }
        protected override void OnInitialized()
        {
            logger.LogInformation("Iniciando componente");
            Console.WriteLine("Iniciando componente");
        }
    }
}
