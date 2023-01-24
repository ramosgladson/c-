public static string MascaraLatitudeLongitude(this string latitudeOrLongitude)
{
	string mascara = "";
        MaskedTextBox maskedText = new MaskedTextBox();

        if (!string.IsNullOrWhiteSpace(latitudeOrLongitude))
        {
	        if (latitudeOrLongitude.Length == 8 || latitudeOrLongitude.Length == 12)
                {
                    maskedText.Mask = @"-00:00:00,00";

                    maskedText.Text = latitudeOrLongitude.RemoveMascara();

                    mascara = maskedText.Text.Replace(".", ",");
                }
	}

        return mascara;
}
