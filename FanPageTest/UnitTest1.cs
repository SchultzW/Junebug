using System;
using Xunit;
using FanPage;
using FanPage.Models;
using FanPage.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace FanPageTest
{
    public class UnitTest1
    {



        //Add Story to repo
        [Fact]
        public void TestAddStoryRepo()
        {
            //arrange
            var storyRepo = new FakeStoryRepo();
            var controller = new HomeController(storyRepo);
            //act
            controller.WriteStory("Test Writer", "Test Text", "Test Desc", "Test Title");


            //Assert
            Assert.Equal("Test Text", storyRepo.Stories[storyRepo.Stories.Count - 1].StoryText);
        }

        //add comment to repo uses storypage
        [Fact]
        public void TestAddComment()
        {
            //arrange
            var storyRepo = new FakeStoryRepo();
            var controller = new HomeController(storyRepo);
            var s = new Story();
            s.Title = "Test Title";
            //act
            controller.StoryPage("Test Title", "Test User", "Test Comment", 5);
            //assert

            Assert.Equal("Test Comment", storyRepo.Stories[storyRepo.Stories.Count - 1].Comments[0].CommentText);
        }
        //test sort
        [Fact]
        public void TestSort()
        {
            //arrange
            var storyRepo = new FakeStoryRepo();
            var controller = new HomeController(storyRepo);
            //act
            storyRepo.AddTestData();
            controller.Stories();

            //assert
            Assert.Equal("Why can't I sleep in the box?", storyRepo.Stories[2].Title);
        }

    }
}
