using FaSkillSchool.Domain;
using FluentAssertions;

namespace FaSkillSchool.Tests.Domain.Common;

public class BaseEntityTests
{
    [Fact]
    public void All_Derived_Entities_From_BaseEntity_Should_Be_Sealed()
    {
        var assembly = typeof(BaseEntity<>).Assembly;

        var entityTypes = assembly
            .GetTypes()
            .Where(t => !t.IsAbstract && t.BaseType != null)
            .Where(t =>
                t.BaseType.IsGenericType &&
                t.BaseType.GetGenericTypeDefinition() == typeof(BaseEntity<>))
            .ToList();

        entityTypes.Should().NotBeEmpty();
        entityTypes.Count().Should().BeGreaterThan(0);

        foreach (var type in entityTypes)
        {
            type.IsSealed.Should().BeTrue($"{type.FullName} should be sealed.");
        }
    }
}
