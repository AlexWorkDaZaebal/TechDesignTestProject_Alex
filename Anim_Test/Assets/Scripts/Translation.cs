using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Localization.Settings;

public class Translation : MonoBehaviour
{
    public void localTranslate(int id)
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[id];
    }

}
