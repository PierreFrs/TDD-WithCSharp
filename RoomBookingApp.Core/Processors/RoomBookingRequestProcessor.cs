// RoomBookingRequestProcessor.cs -
// ======================================================================0
// Crée par : pfraisse
// Fichier Crée le : 12/09/2024
// Fichier Modifié le : 12/09/2024
// Code développé pour le projet : RoomBookingApp.Core.Tests

using RoomBookingApp.Core.Models;

namespace RoomBookingApp.Core.Processors;

public class RoomBookingRequestProcessor
{
    public RoomBookingResult BookRoom(RoomBookingRequest bookingRequest)
    {
        return new RoomBookingResult
        {
            FullName = bookingRequest.FullName,
            Email = bookingRequest.Email,
            Date = bookingRequest.Date
        };
    }
}