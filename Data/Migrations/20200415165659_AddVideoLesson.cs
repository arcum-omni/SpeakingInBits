using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakingInBits.Data.Migrations
{
    public partial class AddVideoLesson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoLessons",
                columns: table => new
                {
                    LessonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonTitle = table.Column<string>(nullable: false),
                    LessonDescription = table.Column<string>(nullable: true),
                    EmbedCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoLessons", x => x.LessonID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoLessons");
        }
    }
}
