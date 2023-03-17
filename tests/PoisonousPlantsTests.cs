namespace LeetCode;

public class PoisonousPlantsTests {

    [Theory]
    [InlineData(new int[] { 6, 5, 8, 4, 7, 10, 9 }, 2)]
    [InlineData(new int[] { 4, 3, 7, 5, 6, 4, 2 }, 3)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1)]
    [InlineData(new int[] { 20, 5, 6, 15, 2, 2, 17, 2, 11, 5, 14, 5, 10, 9, 19, 12, 5 }, 4)]
    public void ExecuteTests(int[] p, int expected) {

        int actual = PoisonousPlantsSolution.PoisonousPlants(p.ToList());

        Assert.Equal(expected, actual);
    }
}