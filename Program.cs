var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
// Configura��o de rotas para p�ginas Razor e redirecionamento para a p�gina default
app.MapRazorPages();
app.MapGet("/", context => {
    context.Response.Redirect("/Pessoa");
    return Task.CompletedTask;
});

app.UseAuthorization();

app.MapRazorPages();



app.Run();
