using Service.Models;
using Service.Services;

namespace TestAgora
{
    public class UnitTestGenericService
    {
        [Fact]
        public async void TestGetAll()
        {
            // Arrange
            var service = new GenericService<Inscripcion>();
            // Act
            var result = await service.GetAllAsync(null);
            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<Inscripcion>>(result);
            Assert.True(result.Count > 0); // Asumiendo que siempre hay datos en la base de datos
            foreach (var item in result)
            {
                //imprimimos las capacitaciones
                Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
            }

        }
    }
}