﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaAPITUPAustral.Migrations
{
    /// <inheritdoc />
    public partial class RollbackEmailUniqueInUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }
    }
}
