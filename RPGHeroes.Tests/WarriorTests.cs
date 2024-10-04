using Xunit;
using RPGHeroes;

public class WarriorTests
{
    [Fact]
    public void Warrior_Should_Have_Correct_Name_After_Creation()
    {
        // Arrange
        var warrior = new Warrior("Conan");

        // Act
        var name = warrior.Name;

        // Assert
        Assert.Equal("Conan", name);
    }

    [Fact]
    public void Warrior_Should_Increment_Level_When_LevelUp_Is_Called()
    {
        // Arrange
        var warrior = new Warrior("Conan");

        // Act
        warrior.LevelUp(); // Assuming LevelUp method increases the level

        // Assert
        Assert.Equal(2, warrior.Level); // Change this based on your leveling logic
    }

    // Add more tests as needed...

    [Fact]
    
    public void Warrior_Should_Equip_Weapon_Correctly()
    {
        // Arrange
        var warrior = new Warrior("Conan");
        var axe = new Weapon("Battle Axe", 1, WeaponType.Axe, 5);

        // Act
        warrior.Equip(axe); // This will now work with the Equip method

        // Assert
        Assert.Equal(axe, warrior.Equipment[Slot.Weapon]);
    }


}

