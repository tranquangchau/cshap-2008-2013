function togglediv(divids,dividh)
{

document.getElementById(divids).style.display = 'none';
document.getElementById(dividh).style.display = 'block';

return false;
}




function showAdv( )
{

togglediv("basic","adv");
//togglediv("results","adv");
togglediv("switchcAdv","switchcBas");

document.getElementById("unitsa").value="";
document.getElementById("opra").value="";
document.getElementById("defectsa").value="";
document.getElementById("sigmashifta").value=1.5;

document.getElementById("dpmo").value="";
document.getElementById("defectsper").value="";
document.getElementById("yeildper").value="";
document.getElementById("prsigma").value="";


}

function showBasic()
{

togglediv("adv","basic");
//togglediv("results","basic");
togglediv("switchcBas","switchcAdv");
document.getElementById("oprb" ).value="";
document.getElementById("defectsb").value="";

document.getElementById("dpmo").value="";
document.getElementById("defectsper").value="";
document.getElementById("yeildper").value="";
document.getElementById("prsigma").value="";

}



function CalcBasic()
{
	var oppr=parseFloat(eval(document.getElementById("oprb" ).value));
	var defects=parseFloat(eval(document.getElementById("defectsb").value));
	var sigmashift=1.50;

	var dpmo,defectper,yeildper,sigmalevel;

	if(oppr!=0)
	{

	dpmo=(defects/(oppr))*1000000;

	}

	//togglediv("basic", "results");

         document.getElementById('results').style.display = 'block';
	
	document.getElementById("dpmo").value=roundNumber(dpmo,0);


	defectper=(defects*100)/oppr;


	document.getElementById("defectsper").value=roundNumber(defectper,2);

	yeildper=100-defectper;

	document.getElementById("yeildper").value=roundNumber(yeildper,2);





	var nimv=NORMSINV(dpmo/1000000);


	if(oppr!=0)
	{
	   if( (dpmo/1000000)>0.933199)
		{
			sigmalevel=0;
		} 

	   if((dpmo/1000000)>0.5)
		{
		   sigmalevel=1.5-Math.abs(nimv); 

		}
	    else
		{
		 sigmalevel=Math.abs(nimv)+1.5;
	  	}	

	}

	if(isNaN(sigmalevel))
	{
	document.getElementById("prsigma").value="-infinity Z";
	}
	else
	{	
	document.getElementById("prsigma").value=roundNumber(sigmalevel,2);
	}
}



function CalcAdvance()
{
      
	var units=eval(document.getElementById("unitsa").value);
	var opprpu=eval(document.getElementById("opra").value);
	var defects=eval(document.getElementById("defectsa").value);
	var sigmashift=eval(document.getElementById("sigmashifta").value);

	var dpmo,defectper,yeildper,sigmalevel;

	if(units!=0)
	{

	dpmo=(defects/(units*opprpu))*1000000;

	}

	//togglediv("adv", "results");

	document.getElementById('results').style.display = 'block';
	document.getElementById("dpmo").value=roundNumber(dpmo,0);


	defectper=(defects*100)/(units*opprpu);

	document.getElementById("defectsper").value=roundNumber(defectper,2);

	yeildper=100-defectper;
	document.getElementById("yeildper").value=roundNumber(yeildper,2);



	var nimv=NORMSINV(dpmo/1000000);
	
	if(units!=0)
	{

		if( (dpmo/1000000)>0.933199)
		{
			sigmalevel=0;
		} 

	  	 if((dpmo/1000000)>0.5)
		{
		   sigmalevel=1.5-Math.abs(nimv); 

		}
	    	else
		{
		 sigmalevel=Math.abs(nimv)+sigmashift;
	  	}	
		
	}
	
	if(isNaN(sigmalevel))
	{
	document.getElementById("prsigma").value="-infinity Z";
	}
        else
	{
	document.getElementById("prsigma").value=roundNumber(sigmalevel,2);
	}



}








function NORMSINV(p)
{
    // Coefficients in rational approximations
    var a = new Array(-3.969683028665376e+01,  2.209460984245205e+02,
                      -2.759285104469687e+02,  1.383577518672690e+02,
                      -3.066479806614716e+01,  2.506628277459239e+00);

    var b = new Array(-5.447609879822406e+01,  1.615858368580409e+02,
                      -1.556989798598866e+02,  6.680131188771972e+01,
                      -1.328068155288572e+01 );

    var c = new Array(-7.784894002430293e-03, -3.223964580411365e-01,
                      -2.400758277161838e+00, -2.549732539343734e+00,
                      4.374664141464968e+00,  2.938163982698783e+00);

    var d = new Array (7.784695709041462e-03, 3.224671290700398e-01,
                       2.445134137142996e+00,  3.754408661907416e+00);

    // Define break-points.
    var plow  = 0.02425;
    var phigh = 1 - plow;

    // Rational approximation for lower region:
    if ( p < plow ) {
             var q  = Math.sqrt(-2*Math.log(p));
             return (((((c[0]*q+c[1])*q+c[2])*q+c[3])*q+c[4])*q+c[5]) /
                                             ((((d[0]*q+d[1])*q+d[2])*q+d[3])*q+1);
    }

    // Rational approximation for upper region:
    if ( phigh < p ) {
             var q  = Math.sqrt(-2*Math.log(1-p));
             return -(((((c[0]*q+c[1])*q+c[2])*q+c[3])*q+c[4])*q+c[5]) /
                                                    ((((d[0]*q+d[1])*q+d[2])*q+d[3])*q+1);
    }

    // Rational approximation for central region:
    var q = p - 0.5;
    var r = q*q;
    return (((((a[0]*r+a[1])*r+a[2])*r+a[3])*r+a[4])*r+a[5])*q /
                             (((((b[0]*r+b[1])*r+b[2])*r+b[3])*r+b[4])*r+1);
}


function roundNumber(num, dec) {
	var result = Math.round(num*Math.pow(10,dec))/Math.pow(10,dec);
	return result;
}

