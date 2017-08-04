using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phoneEmailWeb : MonoBehaviour {

	/* ------------------------------------------------------------------------- */
	// open facebook page
	public void openTechandBeerFacebookPage ()
	{
		float startTime;
		startTime = Time.timeSinceLevelLoad;

		// open the facebook app in IOS
		Application.OpenURL("fb://page/?id=350989365287405");
		// open the facebook app in Andorid
		Application.OpenURL ("fb://page/350989365287405");

		if (Time.timeSinceLevelLoad - startTime <= 1f)
		{
			//fail. Open safari.
			Application.OpenURL("https://www.facebook.com/Orlandotechandbeer/");
		}
	}

	/* ------------------------------------------------------------------------- */
	// open webpage 
	public void openLaunchableWebPage ()
	{
		Application.OpenURL("https://teamlaunchable.com/");
	}

	public void openPanderaWebPage ()
	{
		Application.OpenURL ("http://panderasystems.com/");
	}

	public void TeamLaunchableSite ()
	{
		Application.OpenURL ("https://TeamLaunchable.com");
	}


	/* ------------------------------------------------------------------------- */
	// phone call

	public void Phone_Launchable ()
	{
		Application.OpenURL ("tel://4079063034");
	}

	public void Phone_Dollar ()
	{
		Application.OpenURL ("tel://5613058898");
	}

	public void Phone_Timbr ()
	{
		Application.OpenURL ("tel://4042711157");
	}

	public void Phone_PALS ()
	{
		Application.OpenURL ("tel://4079065514");
	}

	public void Phone_Edgefactory ()
	{
		Application.OpenURL ("tel://4072913343");
	}

	public void Phone_MattThomas ()
	{
		Application.OpenURL ("tel://18883868420");
	}

	public void Phone_Transient ()
	{
		Application.OpenURL ("tel://4074913299");
	}

	/* ------------------------------------------------------------------------- */
//	 open email 
	public void Email_Launchable ()
	{
		string email = "Alfred@TeamLaunchable.com";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}

	public void Email_Dollar ()
	{
		string email = "Joe@TeamLaunchable.com";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}

	public void Email_Ghost ()
	{
		string email = "paranormal.intuition@gmail.com";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}

	public void Email_Grow ()
	{
		string email = "vzabala@growfl.com";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}

	public void Email_Timbr ()
	{
		string email = "walker@timbrtech.com";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}

	public void Email_PALS ()
	{
		string email = "jeff@drinksforpals.com";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}

	public void Email_Caleb ()
	{
		string email = "caleb@thegreenhouseagency.com";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}

	public void Email_Edgefactory ()
	{
		string email = "info@edgefactory.com";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}

	public void Email_MattThomas ()
	{
		string email = "info@panderasystems.com";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}

	public void Email_Parker ()
	{
		string email = "Parker.beatbox@gmail.com";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}

	public void Email_Transient ()
	{
		string email = "Tom@transientpath.com";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}

	public void Email_TechLaw ()
	{
		string email = "donna@thetechlawfirm.com";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}


	string MyEscapeURL (string url)
	{
		return WWW.EscapeURL(url).Replace("+","%20");
	}
	/* ------------------------------------------------------------------------- */

}