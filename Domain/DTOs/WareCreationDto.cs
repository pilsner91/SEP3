namespace Shared.DTOs; 

public class WareCreationDto {

    public string KundeNummer { get; }
    public string VareNummer { get; }
    public string VareAntal { get; }
    
    public WareCreationDto(string kundeNummer, string vareNummer, string vareAntal)
    {
        KundeNummer = kundeNummer;
        VareNummer = vareNummer;
        VareAntal = vareAntal;

    }
}

