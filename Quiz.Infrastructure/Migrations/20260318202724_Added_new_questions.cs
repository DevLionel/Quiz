using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Quiz.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Added_new_questions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AnswerText",
                value: "Waar");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AnswerText",
                value: "Niet Waar");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column:  "AnswerText",
                value: "Waar");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AnswerText",
                value: "Niet Waar"); 

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "QuestionText",
                value: "Is de eiffeltoren hoger dan 300 meter?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column:  "QuestionText",
                value:  "Heeft Nederland meer fietsen dan inwoners?");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "MediaType", "MediaUrl", "QuestionText", "QuizTemplateId" },
                values: new object[,]
                {
                    { 3, 0, null, "Is de mens de snelste landzoogdier ter wereld?", 1 },
                    { 4, 0, null, "Ligt Australië op het zuidelijk halfrond?", 1 },
                    { 5, 0, null, "Heeft een octopus meer of minder dan 6 armen?", 3 },
                    { 6, 0, null, "Ligt de gemiddelde lichaamstemperatuur van een mens hoger of lager dan 38 graden Celsius?", 3 },
                    { 7, 0, null, "Heeft een jaar meer of minder dan 400 dagen?", 3 },
                    { 8, 0, null, "Is de afstand van Amsterdam naar Parijs meer of minder dan 500 kilometer?", 3 },
                    { 9, 0, null, "Welke planeet is het grootst in ons zonnestelsel?", 2 },
                    { 10, 0, null, "In welk jaar viel de Berlijnse Muur?", 2 },
                    { 11, 0, null, "Wie schreef het boek 'De Ontdekking van de Hemel'?", 2 },
                    { 12, 0, null, "Welk element heeft het chemische symbool 'Au'?", 2 },
                    { 13, 0, null, "Welke sport wordt gespeeld bij Wimbledon?", 2 },
                    { 14, 0, null, "Is de walvis een vis?", 1 },
                    { 15, 0, null, "Heeft een mens meer of minder dan 200 botten in zijn lichaam?", 3 }
                });

            migrationBuilder.UpdateData(
              table: "Answers",
              keyColumn: "Id",
              keyValue: 5,
              columns: new[] { "AnswerText","IsCorrect", "QuestionId" },
              values: new object[] { "Waar", false, 3 });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerText", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { 6, "Niet Waar", true, 3 },
                    { 7, "Waar", true, 4 },
                    { 8, "Niet Waar", false, 4 },
                    { 9, "Meer", true, 5 },
                    { 10, "Minder", false, 5 },
                    { 11, "Hoger", false, 6 },
                    { 12, "Lager", true, 6 },
                    { 13, "Meer", false, 7 },
                    { 14, "Minder", true, 7 },
                    { 15, "Meer", false, 8 },
                    { 16, "Minder", true, 8 },
                    { 17, "A. Mars", false, 9 },
                    { 18, "B. Saturnus", false, 9 },
                    { 19, "C. Jupiter", true, 9 },
                    { 20, "D. Neptunus", false, 9 },
                    { 21, "A. 1985", false, 10 },
                    { 22, "B. 1989", true, 10 },
                    { 23, "C. 1991", false, 10 },
                    { 24, "D. 1993", false, 10 },
                    { 25, "A. Harry Mulisch", true, 11 },
                    { 26, "B. Maarten 't Hart", false, 11 },
                    { 27, "C. Cees Nooteboom", false, 11 },
                    { 28, "D. Gerard Reve", false, 11 },
                    { 29, "A. Zilver", false, 12 },
                    { 30, "B. Aluminium", false, 12 },
                    { 31, "C. Goud", true, 12 },
                    { 32, "D. Argon", false, 12 },
                    { 33, "A. Badminton", false, 13 },
                    { 34, "B. Tennis", true, 13 },
                    { 35, "C. Cricket", false, 13 },
                    { 36, "D. Squash", false, 13 },
                    { 37, "Waar", false, 14 },
                    { 38, "Niet Waar", true, 14 },
                    { 39, "Meer", true, 15 },
                    { 40, "Minder", false, 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AnswerText",
                value: "True");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AnswerText",
                value: "False");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AnswerText", "IsCorrect" },
                values: new object[] { "Berlin", false });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AnswerText", "IsCorrect" },
                values: new object[] { "Paris", true });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AnswerText", "QuestionId" },
                values: new object[] { "Madrid", 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "QuestionText",
                value: "The Earth is round.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "QuestionText", "QuizTemplateId" },
                values: new object[] { "What is the capital of France?", 2 });
        }
    }
}
