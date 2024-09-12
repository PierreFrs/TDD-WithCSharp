// RoomBookingRequest.cs -
// ======================================================================0
// Crée par : pfraisse
// Fichier Crée le : 12/09/2024
// Fichier Modifié le : 12/09/2024
// Code développé pour le projet : RoomBookingApp.Core.Tests

namespace RoomBookingApp.Core.Models;

public class RoomBookingRequest
{
    public string FullName { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public DateTime Date { get; set; } = DateTime.MinValue;
}