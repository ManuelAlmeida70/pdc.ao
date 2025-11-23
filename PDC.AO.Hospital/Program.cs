using PDC.AO.Insfrastructure;
using PDC.AO.Aplication;

var builder = WebApplication.CreateBuilder(args);

// 1. Adicionar serviços do MVC
builder.Services.AddControllersWithViews();


builder.Services.AddInfrastruture(builder.Configuration);
builder.Services.AddAplication();


var app = builder.Build();

// 2. Ativar arquivos estáticos (wwwroot)
app.UseStaticFiles();

// 3. Ativar roteamento
app.UseRouting();

// 4. Mapear rotas padrão do MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

// 5. Rodar a aplicação
app.Run();
