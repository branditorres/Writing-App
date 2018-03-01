namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CharaInfoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        userID = c.Int(nullable: false),
                        fullName = c.String(),
                        nickname = c.String(),
                        age = c.String(),
                        dob = c.String(),
                        zodiac = c.String(),
                        romantic = c.String(),
                        sexual = c.String(),
                        religion = c.String(),
                        nationality = c.String(),
                        ethnicity = c.String(),
                        gender = c.String(),
                        pronouns = c.String(),
                        curlocation = c.String(),
                        livingcon = c.String(),
                        birthPlace = c.String(),
                        socialClass = c.String(),
                        educationlvl = c.String(),
                        parentOne = c.String(),
                        parentTwo = c.String(),
                        siblings = c.String(),
                        children = c.String(),
                        pets = c.String(),
                        otherRelatives = c.String(),
                        prevRelationships = c.String(),
                        arrests = c.String(),
                        prison = c.String(),
                        talents = c.String(),
                        shortcomings = c.String(),
                        languages = c.String(),
                        faceClaim = c.String(),
                        eyeColor = c.String(),
                        hairColor = c.String(),
                        hairStyle = c.String(),
                        dominantHand = c.String(),
                        weight = c.String(),
                        height = c.String(),
                        build = c.String(),
                        skinTone = c.String(),
                        Tattoos = c.String(),
                        piercings = c.String(),
                        marksScars = c.String(),
                        notableFeats = c.String(),
                        usualExpress = c.String(),
                        style = c.String(),
                        jewelry = c.String(),
                        allergies = c.String(),
                        bodyTemp = c.String(),
                        physicalAilments = c.String(),
                        jungType = c.String(),
                        enneagramType = c.String(),
                        moralAlign = c.String(),
                        temperament = c.String(),
                        element = c.String(),
                        primaryIntType = c.String(),
                        approxIQ = c.String(),
                        mentalDisorders = c.String(),
                        obessions = c.String(),
                        compulsions = c.String(),
                        phobias = c.String(),
                        addictions = c.String(),
                        drugUse = c.String(),
                        alcoholUse = c.String(),
                        speechStyles = c.String(),
                        accent = c.String(),
                        quirks = c.String(),
                        hobbies = c.String(),
                        habits = c.String(),
                        nervousTics = c.String(),
                        drivesMotiv = c.String(),
                        fears = c.String(),
                        posTraits = c.String(),
                        negTraits = c.String(),
                        virtues = c.String(),
                        vices = c.String(),
                        likes = c.String(),
                        dislikes = c.String(),
                        aesthetic = c.String(),
                        playlist = c.String(),
                        relfriend1 = c.String(),
                        relfriend2 = c.String(),
                        relfriend3 = c.String(),
                        relfriend4 = c.String(),
                        relparent1 = c.String(),
                        relparent2 = c.String(),
                        relsibling1 = c.String(),
                        relsibling2 = c.String(),
                        relsibling3 = c.String(),
                        relsibling4 = c.String(),
                        relpartner1 = c.String(),
                        relpartner2 = c.String(),
                        relpartner3 = c.String(),
                        relpartner4 = c.String(),
                        biography = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProjectInfoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                        projectTitle = c.String(),
                        dateCreated = c.DateTime(nullable: false),
                        genre = c.String(),
                        type = c.String(),
                        progress = c.String(),
                        wordCount = c.String(),
                        triggerWs = c.String(),
                        charasInvolved = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        age = c.String(),
                        nickname = c.String(),
                        shortBio = c.String(),
                        location = c.String(),
                        numberProjects = c.String(),
                        yearsExp = c.String(),
                        dateCreated = c.DateTime(nullable: false),
                        totalWC = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Writings", "title", c => c.String());
            AlterColumn("dbo.Writings", "userId", c => c.Int(nullable: false));
            DropColumn("dbo.Writings", "tags");
            DropColumn("dbo.Writings", "projectName");
            DropTable("dbo.Students");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Fname = c.String(),
                        Lname = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Writings", "projectName", c => c.String());
            AddColumn("dbo.Writings", "tags", c => c.String());
            AlterColumn("dbo.Writings", "userId", c => c.String());
            DropColumn("dbo.Writings", "title");
            DropTable("dbo.UserInfoes");
            DropTable("dbo.ProjectInfoes");
            DropTable("dbo.CharaInfoes");
        }
    }
}
