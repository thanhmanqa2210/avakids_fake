using System.Net;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseStatusCodePages(
    appError =>
    {
        appError.Run(async context =>
        {
            var response = context.Response;
            var code = response.StatusCode;
            var content = @$"
                    <html>
                        <head>
                            <meta charset='UTF-8'/>
                            <title>Lỗi {code}</title>
                        </head>
                        <body>
                            <p>
                            Có lỗi xảy ra: {code} - {(HttpStatusCode)code}
                            </p>
                        </body>
                    </html>
            ";
            await response.WriteAsync(content);
        });
    }
);
app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "HomeProducts",
    defaults: new { controller = "Home", action = "Products", },
    pattern: "/{controller}/{action}/"
    );
app.MapControllerRoute(
name: "default",
defaults: new { controller = "Home", action = "ProductDetails", id = 1 },
pattern: "/{controller}/{action}/{id}"
);


app.Run();
