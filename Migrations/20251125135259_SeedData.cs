using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_Commerce_Outdoorways.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Price", "ProductDesc", "ProductIMG", "ProductName", "ProductQty" },
                values: new object[,]
                {
                    { 1, 1, 129.99m, "High-quality winter jacket designed for extreme cold. Warm, durable and perfect for outdoor adventures.", "jacket1.jpg", "Men Winter Jacket", 20 },
                    { 2, 2, 149.99m, "Premium women’s winter coat crafted for warmth, comfort and style. Ideal for harsh winter conditions.", "coat1.jpg", "Women Winter Coat", 15 },
                    { 3, 3, 39.99m, "Soft and comfortable hoodie for kids. Perfect for school, play, or layering on chilly days.", "hoodie.jpg", "Kids Hoodie", 30 },
                    { 4, 4, 49.99m, "Classic autumn flannel shirt made from breathable cotton. A warm and stylish choice for the fall season.", "flannel.jpg", "Autumn Flannel Shirt", 40 },
                    { 5, 5, 19.99m, "Insulated thermal gloves for maximum warmth. Ideal for winter sports, hiking, and everyday use.", "gloves.jpg", "Winter Thermal Gloves", 50 },
                    { 6, 6, 69.99m, "Lightweight spring jacket designed for mild weather. Wind-resistant and comfortable for outdoor activities.", "lightjacket.jpg", "Spring Light Jacket", 22 },
                    { 7, 7, 15.99m, "Breathable, comfortable summer t-shirt made from soft cotton. Perfect for hot days and outdoor adventures.", "tshirt.jpg", "Summer T-Shirt", 60 },
                    { 8, 7, 24.99m, "Light and durable summer shorts designed for maximum comfort. Ideal for hiking, beach, and casual wear.", "shorts.jpg", "Summer Shorts", 45 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FullName", "Password", "Type" },
                values: new object[] { 1, "realiriccardo05@gmail.com", "Riccardo Reali", "W_Back_End", "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);
        }
    }
}
