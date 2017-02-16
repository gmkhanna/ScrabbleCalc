using System;
using Xunit;
using System.Collections.Generic;
using ScrabbleCalc.Objects;

namespace ScrabbleCalc
{
    public class ScrabbleCalcTest
    {
        [Fact]
        public void IsScrabble_ScoreOfLetter_1()
        {
            //Arrange
            string inputTest = "E";
            int resultTest = 1;

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            int result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfLetter_2()
        {
            //Arrange
            string inputTest = "D";
            int resultTest = 2;

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            int result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfLetter_3()
        {
            //Arrange
            string inputTest = "B";
            int resultTest = 3;

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            int result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfLetter_4()
        {
            //Arrange
            string inputTest = "F";
            int resultTest = 4;

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            int result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfLetter_5()
        {
            //Arrange
            string inputTest = "K";
            int resultTest = 5;

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            int result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfLetter_8()
        {
            //Arrange
            string inputTest = "J";
            int resultTest = 8;

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            int result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfLetter_10()
        {
            //Arrange
            string inputTest = "Z";
            int resultTest = 10;

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            int result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfInvalidLetter_0()
        {
            //Arrange
            string inputTest = "!";
            int resultTest = 0;

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            int result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfLowerCaseLetter_1()
        {
            //Arrange
            string inputTest = "a";
            int resultTest = 1;

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            int result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }
    }
}
