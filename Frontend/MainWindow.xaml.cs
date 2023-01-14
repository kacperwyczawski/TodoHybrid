using System.Windows;
using Backend;
using Backend.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Frontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            var services = new ServiceCollection();
            services.AddWpfBlazorWebView();
            services.AddDbContext<TodoDbContext>(options => options.UseInMemoryDatabase("TodoDb"));
            services.AddScoped<TodoItemsService>();
            Resources.Add("services", services.BuildServiceProvider());
        }
    }
}