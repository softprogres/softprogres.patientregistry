﻿using SoftProgres.PatientRegistry.Api.ServiceModel.Types;

namespace SoftProgres.PatientRegistry.Api.Helpers;

public class BirthNumberHelper : IBirthNumberHelper
{
    /// <summary>
    /// Získa dátum narodenia osoby z rodného čísla.
    /// Rodné číslo nie je potrebné validovať, predpokladajte, že je validné.
    /// </summary>
    /// <param name="birthNumber">Validné rodné číslo v tvare s lomkou alebo bez lomky.</param>
    /// <returns>Dátum narodenia osoby</returns>
    public DateTime GetDateOfBirthFromBirthNumber(string birthNumber)
    {
        // TODO implementovať získanie dátumu narodenia osoby z rodného čísla.
        throw new NotImplementedException();
    }

    /// <summary>
    /// Získa dátum narodenia osoby z rodného čísla.
    /// Rodné číslo nie je potrebné validovať, predpokladajte, že je validné.
    /// </summary>
    /// <param name="birthNumber">Validné rodné číslo v tvare s lomkou alebo bez lomky.</param>
    /// <returns>Vek osoby</returns>
    public int GetAgeFromBirthNumber(string birthNumber)
    {
        // TODO implementovať získanie veku osoby z rodného čísla.
        throw new NotImplementedException();
    }

    /// <summary>
    /// Získa pohlavie osoby z rodného čísla.
    /// Rodné číslo nie je potrebné validovať, predpokladajte, že je validné.
    /// </summary>
    /// <param name="birthNumber">Validné rodné číslo v tvare s lomkou alebo bez lomky.</param>
    /// <returns>Pohlavie osoby</returns>
    public Sex GetSexFromBirthNumber(string birthNumber)
    {
        // TODO implementovať získanie pohlavia osoby z rodného čísla.
        throw new NotImplementedException();
    }
}