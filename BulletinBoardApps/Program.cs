var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// 2024/7/27 Y.Uchida 初期構築に伴いコメントアウト
// 2024/7/27 Y.Uchida Commented out with initial construction.
//builder.Services.AddRazorPages();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// 2024/7/27 Y.Uchida 初期構築に伴いコメントアウト
// 2024/7/27 Y.Uchida Commented out with initial construction.
//app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
