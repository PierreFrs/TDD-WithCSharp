// RoomBookingRequestProcessorTest.cs -
// ======================================================================0
// Crée par : pfraisse
// Fichier Crée le : 12/09/2024
// Fichier Modifié le : 12/09/2024
// Code développé pour le projet : RoomBookingApp.Core.Tests

using RoomBookingApp.Core.Models;
using RoomBookingApp.Core.Processors;
using Shouldly;

namespace RoomBookingApp.Core;

public class RoomBookingRequestProcessorTest
{
    [Fact]
    public void ShouldReturnRoomBookingResponseWithValue()
    {
        // Arrange
        var request = new RoomBookingRequest
        {
            FullName = "Test Name",
            Email = "test@request.com",
            Date = new DateTime(2021, 03, 23),
        };
        
        var processor = new RoomBookingRequestProcessor();

        // Act
        RoomBookingResult result = processor.BookRoom(request);
        
        // Assert
        
        // Assert.NotNull(result);
        // Assert.Equal(request.FullName, result.FullName);
        // Assert.Equal(request.Email, result.Email);
        // Assert.Equal(request.Date, result.Date);

        result.ShouldNotBeNull();
        result.FullName.ShouldBe(request.FullName);
        result.Email.ShouldBe(request.Email);
        result.Date.ShouldBe(request.Date);
    }
}