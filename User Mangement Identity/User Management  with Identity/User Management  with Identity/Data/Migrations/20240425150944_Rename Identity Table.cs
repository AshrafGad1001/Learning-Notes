using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace User_Management__with_Identity.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameIdentityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.EnsureSchema(
                name: "security");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "userTokens",
                newSchema: "security");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "users",
                newSchema: "security");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "userRoles",
                newSchema: "security");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "userLogins",
                newSchema: "security");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "userClaims",
                newSchema: "security");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Roles",
                newSchema: "security");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "RoleClaims",
                newSchema: "security");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "security",
                table: "userRoles",
                newName: "IX_userRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "security",
                table: "userLogins",
                newName: "IX_userLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "security",
                table: "userClaims",
                newName: "IX_userClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "security",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userTokens",
                schema: "security",
                table: "userTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                schema: "security",
                table: "users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userRoles",
                schema: "security",
                table: "userRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_userLogins",
                schema: "security",
                table: "userLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_userClaims",
                schema: "security",
                table: "userClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                schema: "security",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                schema: "security",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                schema: "security",
                table: "RoleClaims",
                column: "RoleId",
                principalSchema: "security",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userClaims_users_UserId",
                schema: "security",
                table: "userClaims",
                column: "UserId",
                principalSchema: "security",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userLogins_users_UserId",
                schema: "security",
                table: "userLogins",
                column: "UserId",
                principalSchema: "security",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userRoles_Roles_RoleId",
                schema: "security",
                table: "userRoles",
                column: "RoleId",
                principalSchema: "security",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userRoles_users_UserId",
                schema: "security",
                table: "userRoles",
                column: "UserId",
                principalSchema: "security",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userTokens_users_UserId",
                schema: "security",
                table: "userTokens",
                column: "UserId",
                principalSchema: "security",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                schema: "security",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_userClaims_users_UserId",
                schema: "security",
                table: "userClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_userLogins_users_UserId",
                schema: "security",
                table: "userLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_userRoles_Roles_RoleId",
                schema: "security",
                table: "userRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_userRoles_users_UserId",
                schema: "security",
                table: "userRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_userTokens_users_UserId",
                schema: "security",
                table: "userTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userTokens",
                schema: "security",
                table: "userTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                schema: "security",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userRoles",
                schema: "security",
                table: "userRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userLogins",
                schema: "security",
                table: "userLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userClaims",
                schema: "security",
                table: "userClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                schema: "security",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                schema: "security",
                table: "RoleClaims");

            migrationBuilder.RenameTable(
                name: "userTokens",
                schema: "security",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "users",
                schema: "security",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "userRoles",
                schema: "security",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "userLogins",
                schema: "security",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "userClaims",
                schema: "security",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "Roles",
                schema: "security",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "security",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_userRoles_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_userLogins_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_userClaims_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
