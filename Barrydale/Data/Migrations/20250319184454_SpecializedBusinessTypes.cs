using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barrydale.Migrations
{
    /// <inheritdoc />
    public partial class SpecializedBusinessTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AcceptsCreditCards",
                table: "Businesses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AcceptsReservations",
                table: "Businesses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AccessibleForDisabled",
                table: "Businesses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccommodationType",
                table: "Businesses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AdmissionFee",
                table: "Businesses",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Amenities",
                table: "Businesses",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AttractionType",
                table: "Businesses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BasePricePerNight",
                table: "Businesses",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BestTimeToVisit",
                table: "Businesses",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Brands",
                table: "Businesses",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessType",
                table: "Businesses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CheckInInstructions",
                table: "Businesses",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cuisine",
                table: "Businesses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DurationHours",
                table: "Businesses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Facilities",
                table: "Businesses",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FamilyFriendly",
                table: "Businesses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasGuidedTours",
                table: "Businesses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasOnlineStore",
                table: "Businesses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasParking",
                table: "Businesses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasPool",
                table: "Businesses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasWifi",
                table: "Businesses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Highlights",
                table: "Businesses",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IncludedItems",
                table: "Businesses",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsEntireProperty",
                table: "Businesses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxGroupSize",
                table: "Businesses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxGuests",
                table: "Businesses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MealTypes",
                table: "Businesses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MeetingPoint",
                table: "Businesses",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfRooms",
                table: "Businesses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OffersDelivery",
                table: "Businesses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OnlineStoreUrl",
                table: "Businesses",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OutdoorAttraction",
                table: "Businesses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PricePerPerson",
                table: "Businesses",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PriceRange",
                table: "Businesses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PrivateToursAvailable",
                table: "Businesses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductTypes",
                table: "Businesses",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecommendedDurationMinutes",
                table: "Businesses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RequiresBooking",
                table: "Businesses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ServesAlcohol",
                table: "Businesses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShopType",
                table: "Businesses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecialDiets",
                table: "Businesses",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TourType",
                table: "Businesses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptsCreditCards",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "AcceptsReservations",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "AccessibleForDisabled",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "AccommodationType",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "AdmissionFee",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "Amenities",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "AttractionType",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "BasePricePerNight",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "BestTimeToVisit",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "Brands",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "BusinessType",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "CheckInInstructions",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "Cuisine",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "DurationHours",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "Facilities",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "FamilyFriendly",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "HasGuidedTours",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "HasOnlineStore",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "HasParking",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "HasPool",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "HasWifi",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "Highlights",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "IncludedItems",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "IsEntireProperty",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "MaxGroupSize",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "MaxGuests",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "MealTypes",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "MeetingPoint",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "NumberOfRooms",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "OffersDelivery",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "OnlineStoreUrl",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "OutdoorAttraction",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "PricePerPerson",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "PriceRange",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "PrivateToursAvailable",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "ProductTypes",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "RecommendedDurationMinutes",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "RequiresBooking",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "ServesAlcohol",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "ShopType",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "SpecialDiets",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "TourType",
                table: "Businesses");
        }
    }
}
