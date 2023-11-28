using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Profile.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedOn", "Email", "FirstName", "IsDeleted", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Dummy Address No_1", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9687), "dummy1@gmail.com", "DummyName_1", false, "DummyLastName_1", null },
                    { 2, "Dummy Address No_2", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9739), "dummy2@gmail.com", "DummyName_2", false, "DummyLastName_2", null },
                    { 3, "Dummy Address No_3", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9742), "dummy3@gmail.com", "DummyName_3", false, "DummyLastName_3", null },
                    { 4, "Dummy Address No_4", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9743), "dummy4@gmail.com", "DummyName_4", false, "DummyLastName_4", null },
                    { 5, "Dummy Address No_5", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9745), "dummy5@gmail.com", "DummyName_5", false, "DummyLastName_5", null },
                    { 6, "Dummy Address No_6", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9749), "dummy6@gmail.com", "DummyName_6", false, "DummyLastName_6", null },
                    { 7, "Dummy Address No_7", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9751), "dummy7@gmail.com", "DummyName_7", false, "DummyLastName_7", null },
                    { 8, "Dummy Address No_8", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9753), "dummy8@gmail.com", "DummyName_8", false, "DummyLastName_8", null },
                    { 9, "Dummy Address No_9", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9755), "dummy9@gmail.com", "DummyName_9", false, "DummyLastName_9", null },
                    { 10, "Dummy Address No_10", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9810), "dummy10@gmail.com", "DummyName_10", false, "DummyLastName_10", null },
                    { 11, "Dummy Address No_11", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9812), "dummy11@gmail.com", "DummyName_11", false, "DummyLastName_11", null },
                    { 12, "Dummy Address No_12", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9814), "dummy12@gmail.com", "DummyName_12", false, "DummyLastName_12", null },
                    { 13, "Dummy Address No_13", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9816), "dummy13@gmail.com", "DummyName_13", false, "DummyLastName_13", null },
                    { 14, "Dummy Address No_14", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9818), "dummy14@gmail.com", "DummyName_14", false, "DummyLastName_14", null },
                    { 15, "Dummy Address No_15", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9820), "dummy15@gmail.com", "DummyName_15", false, "DummyLastName_15", null },
                    { 16, "Dummy Address No_16", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9822), "dummy16@gmail.com", "DummyName_16", false, "DummyLastName_16", null },
                    { 17, "Dummy Address No_17", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9824), "dummy17@gmail.com", "DummyName_17", false, "DummyLastName_17", null },
                    { 18, "Dummy Address No_18", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9828), "dummy18@gmail.com", "DummyName_18", false, "DummyLastName_18", null },
                    { 19, "Dummy Address No_19", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9830), "dummy19@gmail.com", "DummyName_19", false, "DummyLastName_19", null },
                    { 20, "Dummy Address No_20", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9833), "dummy20@gmail.com", "DummyName_20", false, "DummyLastName_20", null },
                    { 21, "Dummy Address No_21", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9834), "dummy21@gmail.com", "DummyName_21", false, "DummyLastName_21", null },
                    { 22, "Dummy Address No_22", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9836), "dummy22@gmail.com", "DummyName_22", false, "DummyLastName_22", null },
                    { 23, "Dummy Address No_23", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9838), "dummy23@gmail.com", "DummyName_23", false, "DummyLastName_23", null },
                    { 24, "Dummy Address No_24", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9840), "dummy24@gmail.com", "DummyName_24", false, "DummyLastName_24", null },
                    { 25, "Dummy Address No_25", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9842), "dummy25@gmail.com", "DummyName_25", false, "DummyLastName_25", null },
                    { 26, "Dummy Address No_26", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9844), "dummy26@gmail.com", "DummyName_26", false, "DummyLastName_26", null },
                    { 27, "Dummy Address No_27", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9845), "dummy27@gmail.com", "DummyName_27", false, "DummyLastName_27", null },
                    { 28, "Dummy Address No_28", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9847), "dummy28@gmail.com", "DummyName_28", false, "DummyLastName_28", null },
                    { 29, "Dummy Address No_29", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9869), "dummy29@gmail.com", "DummyName_29", false, "DummyLastName_29", null },
                    { 30, "Dummy Address No_30", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9871), "dummy30@gmail.com", "DummyName_30", false, "DummyLastName_30", null },
                    { 31, "Dummy Address No_31", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9873), "dummy31@gmail.com", "DummyName_31", false, "DummyLastName_31", null },
                    { 32, "Dummy Address No_32", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9875), "dummy32@gmail.com", "DummyName_32", false, "DummyLastName_32", null },
                    { 33, "Dummy Address No_33", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9877), "dummy33@gmail.com", "DummyName_33", false, "DummyLastName_33", null },
                    { 34, "Dummy Address No_34", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9880), "dummy34@gmail.com", "DummyName_34", false, "DummyLastName_34", null },
                    { 35, "Dummy Address No_35", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9882), "dummy35@gmail.com", "DummyName_35", false, "DummyLastName_35", null },
                    { 36, "Dummy Address No_36", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9883), "dummy36@gmail.com", "DummyName_36", false, "DummyLastName_36", null },
                    { 37, "Dummy Address No_37", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9885), "dummy37@gmail.com", "DummyName_37", false, "DummyLastName_37", null },
                    { 38, "Dummy Address No_38", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9887), "dummy38@gmail.com", "DummyName_38", false, "DummyLastName_38", null },
                    { 39, "Dummy Address No_39", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9889), "dummy39@gmail.com", "DummyName_39", false, "DummyLastName_39", null },
                    { 40, "Dummy Address No_40", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9891), "dummy40@gmail.com", "DummyName_40", false, "DummyLastName_40", null },
                    { 41, "Dummy Address No_41", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9892), "dummy41@gmail.com", "DummyName_41", false, "DummyLastName_41", null },
                    { 42, "Dummy Address No_42", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9894), "dummy42@gmail.com", "DummyName_42", false, "DummyLastName_42", null },
                    { 43, "Dummy Address No_43", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9896), "dummy43@gmail.com", "DummyName_43", false, "DummyLastName_43", null },
                    { 44, "Dummy Address No_44", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9898), "dummy44@gmail.com", "DummyName_44", false, "DummyLastName_44", null },
                    { 45, "Dummy Address No_45", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9900), "dummy45@gmail.com", "DummyName_45", false, "DummyLastName_45", null },
                    { 46, "Dummy Address No_46", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9902), "dummy46@gmail.com", "DummyName_46", false, "DummyLastName_46", null },
                    { 47, "Dummy Address No_47", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9924), "dummy47@gmail.com", "DummyName_47", false, "DummyLastName_47", null },
                    { 48, "Dummy Address No_48", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9926), "dummy48@gmail.com", "DummyName_48", false, "DummyLastName_48", null },
                    { 49, "Dummy Address No_49", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9928), "dummy49@gmail.com", "DummyName_49", false, "DummyLastName_49", null },
                    { 50, "Dummy Address No_50", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9930), "dummy50@gmail.com", "DummyName_50", false, "DummyLastName_50", null },
                    { 51, "Dummy Address No_51", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9932), "dummy51@gmail.com", "DummyName_51", false, "DummyLastName_51", null },
                    { 52, "Dummy Address No_52", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9934), "dummy52@gmail.com", "DummyName_52", false, "DummyLastName_52", null },
                    { 53, "Dummy Address No_53", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9936), "dummy53@gmail.com", "DummyName_53", false, "DummyLastName_53", null },
                    { 54, "Dummy Address No_54", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9938), "dummy54@gmail.com", "DummyName_54", false, "DummyLastName_54", null },
                    { 55, "Dummy Address No_55", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9940), "dummy55@gmail.com", "DummyName_55", false, "DummyLastName_55", null },
                    { 56, "Dummy Address No_56", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9942), "dummy56@gmail.com", "DummyName_56", false, "DummyLastName_56", null },
                    { 57, "Dummy Address No_57", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9943), "dummy57@gmail.com", "DummyName_57", false, "DummyLastName_57", null },
                    { 58, "Dummy Address No_58", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9945), "dummy58@gmail.com", "DummyName_58", false, "DummyLastName_58", null },
                    { 59, "Dummy Address No_59", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9947), "dummy59@gmail.com", "DummyName_59", false, "DummyLastName_59", null },
                    { 60, "Dummy Address No_60", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9949), "dummy60@gmail.com", "DummyName_60", false, "DummyLastName_60", null },
                    { 61, "Dummy Address No_61", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9951), "dummy61@gmail.com", "DummyName_61", false, "DummyLastName_61", null },
                    { 62, "Dummy Address No_62", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9953), "dummy62@gmail.com", "DummyName_62", false, "DummyLastName_62", null },
                    { 63, "Dummy Address No_63", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9954), "dummy63@gmail.com", "DummyName_63", false, "DummyLastName_63", null },
                    { 64, "Dummy Address No_64", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9956), "dummy64@gmail.com", "DummyName_64", false, "DummyLastName_64", null },
                    { 65, "Dummy Address No_65", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9958), "dummy65@gmail.com", "DummyName_65", false, "DummyLastName_65", null },
                    { 66, "Dummy Address No_66", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9981), "dummy66@gmail.com", "DummyName_66", false, "DummyLastName_66", null },
                    { 67, "Dummy Address No_67", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9984), "dummy67@gmail.com", "DummyName_67", false, "DummyLastName_67", null },
                    { 68, "Dummy Address No_68", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9986), "dummy68@gmail.com", "DummyName_68", false, "DummyLastName_68", null },
                    { 69, "Dummy Address No_69", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9988), "dummy69@gmail.com", "DummyName_69", false, "DummyLastName_69", null },
                    { 70, "Dummy Address No_70", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9990), "dummy70@gmail.com", "DummyName_70", false, "DummyLastName_70", null },
                    { 71, "Dummy Address No_71", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9991), "dummy71@gmail.com", "DummyName_71", false, "DummyLastName_71", null },
                    { 72, "Dummy Address No_72", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9993), "dummy72@gmail.com", "DummyName_72", false, "DummyLastName_72", null },
                    { 73, "Dummy Address No_73", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9995), "dummy73@gmail.com", "DummyName_73", false, "DummyLastName_73", null },
                    { 74, "Dummy Address No_74", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9997), "dummy74@gmail.com", "DummyName_74", false, "DummyLastName_74", null },
                    { 75, "Dummy Address No_75", new DateTime(2023, 11, 28, 14, 59, 5, 834, DateTimeKind.Local).AddTicks(9999), "dummy75@gmail.com", "DummyName_75", false, "DummyLastName_75", null },
                    { 76, "Dummy Address No_76", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(1), "dummy76@gmail.com", "DummyName_76", false, "DummyLastName_76", null },
                    { 77, "Dummy Address No_77", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(2), "dummy77@gmail.com", "DummyName_77", false, "DummyLastName_77", null },
                    { 78, "Dummy Address No_78", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(4), "dummy78@gmail.com", "DummyName_78", false, "DummyLastName_78", null },
                    { 79, "Dummy Address No_79", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(6), "dummy79@gmail.com", "DummyName_79", false, "DummyLastName_79", null },
                    { 80, "Dummy Address No_80", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(8), "dummy80@gmail.com", "DummyName_80", false, "DummyLastName_80", null },
                    { 81, "Dummy Address No_81", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(10), "dummy81@gmail.com", "DummyName_81", false, "DummyLastName_81", null },
                    { 82, "Dummy Address No_82", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(12), "dummy82@gmail.com", "DummyName_82", false, "DummyLastName_82", null },
                    { 83, "Dummy Address No_83", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(35), "dummy83@gmail.com", "DummyName_83", false, "DummyLastName_83", null },
                    { 84, "Dummy Address No_84", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(38), "dummy84@gmail.com", "DummyName_84", false, "DummyLastName_84", null },
                    { 85, "Dummy Address No_85", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(40), "dummy85@gmail.com", "DummyName_85", false, "DummyLastName_85", null },
                    { 86, "Dummy Address No_86", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(41), "dummy86@gmail.com", "DummyName_86", false, "DummyLastName_86", null },
                    { 87, "Dummy Address No_87", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(43), "dummy87@gmail.com", "DummyName_87", false, "DummyLastName_87", null },
                    { 88, "Dummy Address No_88", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(45), "dummy88@gmail.com", "DummyName_88", false, "DummyLastName_88", null },
                    { 89, "Dummy Address No_89", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(47), "dummy89@gmail.com", "DummyName_89", false, "DummyLastName_89", null },
                    { 90, "Dummy Address No_90", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(49), "dummy90@gmail.com", "DummyName_90", false, "DummyLastName_90", null },
                    { 91, "Dummy Address No_91", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(51), "dummy91@gmail.com", "DummyName_91", false, "DummyLastName_91", null },
                    { 92, "Dummy Address No_92", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(53), "dummy92@gmail.com", "DummyName_92", false, "DummyLastName_92", null },
                    { 93, "Dummy Address No_93", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(54), "dummy93@gmail.com", "DummyName_93", false, "DummyLastName_93", null },
                    { 94, "Dummy Address No_94", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(56), "dummy94@gmail.com", "DummyName_94", false, "DummyLastName_94", null },
                    { 95, "Dummy Address No_95", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(58), "dummy95@gmail.com", "DummyName_95", false, "DummyLastName_95", null },
                    { 96, "Dummy Address No_96", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(60), "dummy96@gmail.com", "DummyName_96", false, "DummyLastName_96", null },
                    { 97, "Dummy Address No_97", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(62), "dummy97@gmail.com", "DummyName_97", false, "DummyLastName_97", null },
                    { 98, "Dummy Address No_98", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(64), "dummy98@gmail.com", "DummyName_98", false, "DummyLastName_98", null },
                    { 99, "Dummy Address No_99", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(66), "dummy99@gmail.com", "DummyName_99", false, "DummyLastName_99", null },
                    { 100, "Dummy Address No_100", new DateTime(2023, 11, 28, 14, 59, 5, 835, DateTimeKind.Local).AddTicks(68), "dummy100@gmail.com", "DummyName_100", false, "DummyLastName_100", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
