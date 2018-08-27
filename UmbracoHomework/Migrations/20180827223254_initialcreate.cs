﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UmbracoHomework.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SerialNumbers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerialNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Submissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    SerialNumber = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submissions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SerialNumbers",
                column: "Id",
                values: new object[]
                {
                    new Guid("f252516e-fff7-44d1-a496-eb11185381da"),
                    new Guid("238ecbb0-fc17-403f-be6d-5560258c1c59"),
                    new Guid("94617040-7e42-4104-8864-8faf273628cb"),
                    new Guid("6287da38-3591-41c5-ae07-b4c98ebf6925"),
                    new Guid("eb79be63-84e8-4989-bd83-0c9c83446206"),
                    new Guid("1395c94d-29cc-41f8-adf4-132784126768"),
                    new Guid("04ca3c46-6ee0-46b1-a51d-f66a369e4682"),
                    new Guid("90d8e70e-f773-4284-befd-62794c715697"),
                    new Guid("e3eb5134-cf2c-47e2-9e36-45f7474313e8"),
                    new Guid("52023b33-483e-43cc-a36b-41ea6b98334f"),
                    new Guid("e3409c79-37dc-4dc8-b48e-e3d55a818dbf"),
                    new Guid("096622ea-90ae-4f37-8e0a-3f304658a81e"),
                    new Guid("843aa459-a4bf-414a-902f-a1f633f6a9e8"),
                    new Guid("31efa01b-9583-4d91-afa8-157f84ab26da"),
                    new Guid("6a5638ed-1b76-43e3-9320-a07d532c724e"),
                    new Guid("8f27a589-d870-4c8c-b4c5-457361233c7b"),
                    new Guid("1db98c05-cde9-477f-8065-1b01f8435aeb"),
                    new Guid("3ce5aa6e-7fc6-4c34-9221-8fa9c2e8878c"),
                    new Guid("855976f2-d9c6-484b-868a-ce62ec845e5e"),
                    new Guid("a88c4c05-510b-46c0-917b-e26566b8bfa3"),
                    new Guid("36980b00-a353-42cf-a641-f8e1f0a78491"),
                    new Guid("a834fcbf-c65b-4481-9bbe-e1d0cccd4a92"),
                    new Guid("3d1cbc78-2007-4fa0-b37d-83bde91e62a2"),
                    new Guid("6b68d6fc-a4d3-4d2f-9685-7b3c8caa3775"),
                    new Guid("af1fae67-5bdb-46ac-8ae6-306eff889d4b"),
                    new Guid("1698ca5e-0029-4e77-93f8-bd8a3c189dd5"),
                    new Guid("bcefe167-c0c8-4223-9530-7e3641f5678d"),
                    new Guid("9b94b1fd-13c4-41bc-a781-036dc3ce2f70"),
                    new Guid("6b5f90c3-23ec-4183-a67e-e988658669ec"),
                    new Guid("90f42ffb-1022-4f4a-b6d6-cf833ce5cab2"),
                    new Guid("584de439-6744-4bc1-a4dd-1a7775c69add"),
                    new Guid("d402bfc7-e56a-4705-8d54-d8f7aa94e53c"),
                    new Guid("90e1500f-1012-4f3a-98b4-a22180d0f087"),
                    new Guid("64d5ad26-07bd-4e75-b5ea-0db9e3705a87"),
                    new Guid("3b48322e-a130-4ed6-a77d-b4dfde65ad08"),
                    new Guid("2281968e-e3ec-47d9-a6d0-d83303ebe7e0"),
                    new Guid("7c8889ca-4bbb-4a67-bfb8-f83961b22081"),
                    new Guid("2a9c8c26-fad2-4d14-a16f-1298fce298df"),
                    new Guid("7009de9b-2c0e-48e6-a64d-ec66deb500aa"),
                    new Guid("15992f95-03ad-42bc-b24b-be7acbda1de5"),
                    new Guid("3a0c8017-f9ee-42bf-bc2a-bc0e0b39b480"),
                    new Guid("3585ac16-b83b-421a-8276-c185a52f2d8c"),
                    new Guid("a6c060b5-b556-42d7-b632-9d7acb083bcc"),
                    new Guid("6aab469d-4e1b-4dbd-9d7a-113c7b3b6915"),
                    new Guid("77eed7a5-6ebc-42ae-aac8-b40021352687"),
                    new Guid("256ff60c-239f-49d5-95d6-b93500fb07ef"),
                    new Guid("3077c301-4ce4-46be-be77-133df69f9c6e"),
                    new Guid("1dc44c4b-8f59-4974-9902-a1ba7d2cfdf3"),
                    new Guid("beb5d7e8-a25d-4d16-8865-1c33c851766b"),
                    new Guid("51eebf58-a1e4-4a64-ae37-ca02204ff559"),
                    new Guid("f79d8743-79de-4a98-9bda-284c931fb35d"),
                    new Guid("13dc1692-56c4-46e6-ae11-7ebc2f2ede34"),
                    new Guid("6c8a085a-0f43-46fe-95db-e4788a57338d"),
                    new Guid("db572a40-5de9-43e6-b715-d0b3575ccd20"),
                    new Guid("9e4ca605-cb6b-4e97-9818-50e958b37c8b"),
                    new Guid("bbb76bbf-00c9-4c9c-8394-f556b0bb585e"),
                    new Guid("7a4fc4a1-10d2-489e-9d91-4242d85bdd96"),
                    new Guid("a26d2c84-1495-4ecb-a335-32f1dc5d2398"),
                    new Guid("b100ab8e-f6e1-4143-a3e3-4512536e4447"),
                    new Guid("d7bf3620-a749-417c-9f69-a0e12088a5ba"),
                    new Guid("a14042af-ec63-45b6-9b9a-643fdb476278"),
                    new Guid("a97e5b16-9749-49dd-a195-2136927fa6d9"),
                    new Guid("94bded52-3ad6-4434-90bc-fb5a9a6c18e1"),
                    new Guid("80393849-e2ae-4575-a67a-be37350a1513"),
                    new Guid("b1f5c7a7-d50b-4ff0-9d5a-2e34eaac7c69"),
                    new Guid("a9a6fa94-3705-4b0e-b491-6c64c7b4ab80"),
                    new Guid("d46c70ad-5fad-43a1-99a7-acf972df885f"),
                    new Guid("2f732291-f205-471d-bbe5-ffa3fc840479"),
                    new Guid("fc96bd1d-60bc-4adf-8b2b-8d65202de893"),
                    new Guid("4158676e-0e87-4e3a-9c97-91aa6e7c5f90"),
                    new Guid("ce4663d6-bfb5-4193-b6ed-fa8b8ce98d0b"),
                    new Guid("a866d5b4-9713-46ea-9647-483a1e1decb2"),
                    new Guid("b17489ae-e20b-4bf4-91bc-042c1639819f"),
                    new Guid("9f63ad39-4dc5-4408-a425-d2d46cc3e2fd"),
                    new Guid("65abb0c9-3548-45b0-88e0-855a2cde1672"),
                    new Guid("c466eb42-6e02-40e1-9c26-4922ffefce28"),
                    new Guid("8e11bc2a-160d-4d7e-927a-b59cf48d8d16"),
                    new Guid("4bc2a475-a741-4a79-8d9a-7160e7f0758c"),
                    new Guid("3d2a9456-6736-4b73-89a9-66bf33ed91fa"),
                    new Guid("189bd476-bcd0-48e5-9ef9-a3a9079f3df0"),
                    new Guid("a71948e4-632c-4bd9-80f0-6dc9aafee6c7"),
                    new Guid("5ccd9e0a-f9f6-4ec1-af1b-e369586c1be3"),
                    new Guid("484afcb5-ddb0-471a-a42b-9594e64f75f4"),
                    new Guid("e7c4ed1e-9c3e-44da-8c04-4c4dc99e62d7"),
                    new Guid("67129ba2-5bac-47dc-aadc-ddbcfe409a91"),
                    new Guid("7bfb6ebe-bad4-47cb-85ac-76aa2c2eb4c1"),
                    new Guid("11f0868f-52b8-4291-a3c4-ba7292320b6f"),
                    new Guid("951eae4a-0c12-49ba-924a-d2a9c313cb57"),
                    new Guid("cb80f954-1d97-4995-a746-ac07c6637019"),
                    new Guid("06fcaef3-92cf-47a8-b2ce-1873e2c42fa3"),
                    new Guid("9ec32b8a-b55d-4aa4-b90c-b7905641d6d7"),
                    new Guid("f4862e9a-7cca-4d3d-a364-4b3d5984baa3"),
                    new Guid("cd914585-ec18-458d-aaec-0c0a62993b53"),
                    new Guid("b8831448-9c6e-4770-b471-593410a0c366"),
                    new Guid("5aa61306-2948-4978-a839-2a328b37c607"),
                    new Guid("ae0339dd-994a-4d1b-8197-3213208d0261"),
                    new Guid("67ac85ad-71f3-4c97-a703-dc5fb851b0e9"),
                    new Guid("2193b8b8-3f31-44c1-a15a-00e5a44d6326"),
                    new Guid("13fd0ef3-afa2-47a3-8842-72bad44e5303"),
                    new Guid("68a1c6ba-3035-46b3-ab5b-af746b00fa14"),
                    new Guid("bde49778-9b6b-4401-864e-1cd3301d1006")
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SerialNumbers");

            migrationBuilder.DropTable(
                name: "Submissions");
        }
    }
}
