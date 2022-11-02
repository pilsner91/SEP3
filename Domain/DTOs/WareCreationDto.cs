namespace Shared.DTOs; 

public class WareCreationDto {

    private string KundeNummer { get; }
    private string VareNummer { get; }
    private string VareAntal { get; }
    
    public WareCreationDto(string kundeNummer, string vareNummer, string vareAntal)
    {
        KundeNummer = kundeNummer;
        VareNummer = vareNummer;
        VareAntal = vareAntal;

    }
}

