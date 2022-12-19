﻿// <auto-generated />
using LyricsApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LyricsApp.Server.Migrations
{
    [DbContext(typeof(AplicationContext))]
    [Migration("20221018174751_seedata")]
    partial class seedata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LyricsApp.Shared.Music", b =>
                {
                    b.Property<int>("MusicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MusicId"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lyric")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MusicId");

                    b.ToTable("Musics");

                    b.HasData(
                        new
                        {
                            MusicId = 1,
                            Author = "Toni Watson",
                            ImgURL = "https://m.media-amazon.com/images/I/8100HA+tJAL._SS500_.jpg",
                            Lyric = "They say oh my God I see the way you shine\r\nTake your hand, my dear, and place them both in mine\r\nYou know you stopped me dead while I was passing by\r\nAnd now I beg to see you dance just one more time\r\nOoh I see you, see you, see you every time\r\nAnd oh my I, I, I like your style\r\nYou, you make me, make me, make me wanna cry\r\nAnd now I beg to see you dance just one more time\r\nSo they say\r\nDance for me, dance for me, dance for me, oh, oh, oh\r\nI've never seen anybody do the things you do before\r\nThey say move for me, move for me, move for me, ay, ay, ay\r\nAnd when you're done I'll make you do it all again\r\nI said oh my God I see you walking by\r\nTake my hands, my dear, and look me in my eyes\r\nJust like a monkey I've been dancing my whole life\r\nBut you just beg to see me dance just one more time\r\nOoh I see you, see you, see you every time\r\nAnd oh my I, I like your style\r\nYou, you make me, make me, make me wanna cry\r\nAnd now I beg to see you dance just one more time\r\nSo they say\r\nDance for me, dance for me, dance for me, oh, oh, oh\r\nI've never seen anybody do the things you do before\r\nThey say move for me, move for me, move for me, ay, ay, ay\r\nAnd when you're done I'll make you do it all again\r\nThey say\r\nDance for me, dance for me, dance for me, oh, oh, oh, oh, oh, oh, oh\r\nI've never seen anybody do the things you do before\r\nThey say move for me, move for me, move for me, ay, ay, ay\r\nAnd when you're done I'll make you do it all again\r\nOoh\r\nWoah-oh, woah-oh, oh\r\nOoh\r\nAh ah, ah\r\nThey say\r\nDance for me, dance for me, dance for me, oh, oh, oh\r\nI've never seen anybody do the things you do before\r\nThey say move for me, move for me, move for me, ay, ay, ay\r\nAnd when you're done I'll make you do it all again\r\nThey say\r\nDance for me, dance for me, dance for me, oh, oh, oh, oh, oh, oh, oh\r\nI've never seen anybody do the things you do before\r\nThey say move for me, move for me, move for me, ay, ay, ay\r\nAnd when you're done I'll make you do it all again\r\nAll again",
                            Title = "Dance Monkey",
                            VideoUrl = "https://www.youtube.com/watch?v=q0hyYWKXF0Q&ab_channel=TonesAndI"
                        },
                        new
                        {
                            MusicId = 2,
                            Author = "Clean Bandit",
                            ImgURL = "https://ewillingchaque.com/lsjvk/JLt10-poDkjkvMV0_7u1dgHaFj.jpg",
                            Lyric = "Call it love and devotion\r\nCall it the mom's adoration (foundation)\r\nA special bond of creation, hah\r\nFor all the single mums out there\r\nGoing through frustration\r\nClean Bandit, Sean-Da-Paul, Anne-marie, sing, make them hear\r\nShe works the night, by the water\r\nShe's gonna stress, so far away from her father's daughter\r\nShe just wants a life for her baby\r\nAll on her own, no one will come\r\nShe's got to save him (daily struggle)\r\nShe tells him \"ooh love\"\r\nNo one's ever gonna hurt you, love\r\nI'm gonna give you all of my love\r\nNobody matters like you (stay up there, stay up there)\r\nShe tells him \"your life ain't gonna be nothing like my life (straight)\r\nYou're gonna grow and have a good life\r\nI'm gonna do what I've got to do\" (stay up there, stay up there)\r\nSo, rockabye baby, rockabye\r\nI'm gonna rock you\r\nRockabye baby, don't you cry\r\nSomebody's got you\r\nRockabye baby, rockabye\r\nI'm gonna rock you\r\nRockabye baby, don't you cry\r\nRockabye, no (Rockabye-rocka-rocka-rocka-bye) (oh)\r\nRockabye, yeah, yeah (Rockabye-rocka-rocka-rocka-bye)\r\nSingle mom what you doing out there?\r\nFacing the hard life without no fear\r\nJust see and know that you really care\r\n'Cause any obstacle come you well prepared\r\nAnd no mamma you never shed tear\r\n'Cause you haffi set things year after year\r\nAnd you give the youth love beyond compare\r\nYou find the school fee and the bus fare\r\nHmmmm more when paps disappear\r\nIn a wrong bar can't find him nowhere\r\nSteadily you work flow, heavily you know so you nah stop\r\nNo time no time fi a jeer\r\nNow she gotta a six year old\r\nTrying to keep him warm\r\nTrying to keep all the cold\r\nWhen he looks her in the eyes\r\nHe don't know he's safe when she says\r\n\"Ooh love\"\r\nNo one's ever gonna hurt you, love\r\nI'm gonna give you all of my love\r\nNobody matters like you\r\nSo, rockabye baby, rockabye\r\nI'm gonna rock you\r\nRockabye baby, don't you cry\r\nSomebody's got you\r\nRockabye baby, rockabye\r\nI'm gonna rock you\r\nRockabye baby, don't you cry (Bidda-bang-bang-bang, alright then)\r\nRockabye, no (Rockabye-rocka-rocka-rocka-bye) (Oh)\r\nRockabye, yeah (Rockabye-rocka-rocka-rocka-bye) (yeah)\r\nRockabye don't bother cry\r\nLift up your head, lift it up to the sky, yo\r\nRockabye don't bother cry\r\nAngels around you, just joy your eye\r\nNow she gotta a six year old\r\nTrying to keep him warm\r\nTrying to keep all the cold\r\nWhen he looks her in the eyes\r\nHe don't know he's safe when she says\r\nShe tells him \"ooh love\"\r\nNo one's ever gonna hurt you, love\r\nI'm gonna give you all of my love\r\nNobody matters like you (stay up there, stay up there)\r\nShe tells him \"your life ain't gonna be nothing like my life (straight)\r\nYou're gonna grow and have a good life\r\nI'm gonna do what I've got to do\" (yeah)\r\nSo, rockabye baby, rockabye (Rockabye-rocka-rocka-rocka-bye)\r\nI'm gonna rock you\r\nRockabye baby, don't you cry (Rockabye-rocka-rocka-rocka-bye)\r\nSomebody's got you\r\nRockabye baby, rockabye (Rockabye-rocka-rocka-rocka-bye)\r\nI'm gonna rock you\r\nRockabye baby, don't you cry (Bidda-bang-bang-bang, alright then)\r\nRockabye\r\nRockabye don't bother cry\r\nLift up your head, lift it up to the sky, yo (Rockabye!)\r\nRockabye don't bother cry (yeah yeah)\r\nAngels around you, just joy your eye (Rockabye!)\r\nRockabye don't bother cry\r\nLift up your head, lift it up to the sky, yo (Rockabye!)\r\nRockabye don't bother cry\r\nAngels around you, just joy your eye",
                            Title = "Rockabye",
                            VideoUrl = "https://www.youtube.com/watch?v=papuvlVeZg8&ab_channel=CleanBandit"
                        },
                        new
                        {
                            MusicId = 3,
                            Author = "K/DA",
                            ImgURL = "https://i.ytimg.com/vi/3VTkBuxU4yk/maxresdefault.jpg",
                            Lyric = "K/DA\r\nShould we show 'em how we do it every day?\r\nYeah, yeah, yeah\r\nNa, na-na-na, na-na-na-na-na-na\r\nLet's get it\r\nAkali that girl, 'kali go grr\r\n'Kali don't stop, 'kali don't skrrt\r\n'Kali got a job, 'kali go to work\r\n뜨거워 언제나, don't get burnt\r\n넘쳐 흘러 more than a buffet\r\n죽여 주잖아 like I'm buffy\r\n누가 감히 on my huffy\r\n거, 문열지마 that's a rough day (woo)\r\nI'm givin' you more 'cause I'm greater than\r\n필요없는 시험들, 답은 이미\r\nBut all of my numbers are talkin', babe\r\n블루마블 Mrs. 모노폴리 (ooh)\r\n너는 종이 돈이 나는 real money (hey)\r\n필요 없대 너네들이 많은 돈들\r\nGo get it, go get it, go get it, the mission\r\n눈을못떼 모두 그래 너도 그래 (oh)\r\n'Cause I got it different\r\nAll I'll ever know is life up on a throne\r\n시작하면 끝을 보는 거야\r\nYou want\r\nMore\r\nKnow I got it, so here you go (let's go)\r\nYou look like you could use some more (more)\r\nKnow I got it and never runnin' low (low, oh)\r\nYeah, I got more than enough, add it up and away (ay, ay)\r\nYou know I got it like bomb-bomb, blow your mind\r\nNever givin' less and that's how it'll stay (ay, ay)\r\nYou know I got it like all day, all the time\r\nWhen I go, it's for gold\r\nYeah, they cool, but I'm cold\r\nI don't fit in the mold\r\nI'm a rebel\r\nI don't do what you say\r\nMakin' moves, I don't wait\r\nWhile I smile in your face\r\nI got different DNA\r\nWhat's higher than the top? That's me (that's me)\r\nCome take a look before falling at my feet (oh)\r\n조용히 몸을 숙여 봐 (yeah, yeah, yeah)\r\nSo take a look, 나를 기억해 a queen (oh)\r\nAll I'll ever know is life up on a throne\r\n시작하면 끝을 보는 거야\r\nYou want\r\nMore\r\nKnow I got it, so here you go (let's go)\r\nYou look like you could use some more (more)\r\nKnow I got it and never runnin' low (low, oh)\r\nYeah, I got more than enough, add it up and away (ay, ay)\r\nYou know I got it like bomb-bomb, blow your mind\r\nNever givin' less and that's how it'll stay (ay, ay)\r\nYou know I got it like all day, all the time\r\nWay out\r\n感觉犹如海浪, on the wave now\r\n不断往前遨游, never weighed down\r\nThis is how I do it every day, wow, wow\r\n这一路上的奇迹 都记住了你的\r\n每一个瞬间, 无比的耀眼\r\nI know, I know, you want some more\r\n准备好就一起走 givin' it all\r\nMore\r\nKnow I got it, so here you go (let's go, babe)\r\nYou look like you could use some more (more)\r\nKnow I got it and never runnin' low (low)\r\nYeah, I got more than enough, add it up and away (ay, ay)\r\nYou know I got it like bomb-bomb, blow your mind\r\nNever givin' less and that's how it'll stay (ay, ay)\r\nYou know I got it like all day, all the time",
                            Title = "MORE",
                            VideoUrl = "https://www.youtube.com/watch?v=3VTkBuxU4yk&ab_channel=LeagueofLegends"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
