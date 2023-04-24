using NUnit.Framework;
using TestTechniqueLAtelier.Services;
using MathNet.Numerics.Statistics;

namespace UnitTest;

[TestFixture]
public class PlayersTest
{
    
    [TestCase(1.74, 65.5, 21.6)] // Wikipedia Data
    [TestCase(1.88, 80, 22.6)] // First Player IMC on a calculator online
    public void IbmShouldReturnTheIbmFromAHeightAndWeight(double height, double weight, double exeptedResult)
    {
        // Arrange
        PlayersService playerService = new PlayersService();

        // Act
        double result = playerService.IBM(weight, height);

        // Assert
        Assert.AreEqual(exeptedResult, result);
    }

    
    [TestCase(new double[] {1, 3, 3, 6, 7, 8, 9}, 6)] // Wikipedia Data
    [TestCase(new double[] {1, 2, 3, 4, 5, 6, 8, 9}, 4.5)] // Wikipedia Data
    public void MathNetLibraryShouldReturnTheMedianOfAListOfDouble(IEnumerable<double> list, double exeptedResult)
    {
        // Arrange
        PlayersService playerService = new PlayersService();

        // Act
        double result = list.Median();

        // Assert
        Assert.AreEqual(exeptedResult, result);
    }

}