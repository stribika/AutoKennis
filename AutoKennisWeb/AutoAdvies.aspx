<%@ Page Language="C#" Inherits="AutoKennisWeb.AutoAdvies" %>

<!DOCTYPE HTML>
<html>
  
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <!-- Start of the headers for CoffeeCup Web Form Builder -->
    <script type="text/javascript" src="common/js/form_init.js" data-name=""
    id="form_init_script">
    </script>
    <link rel="stylesheet" type="text/css" href="theme/default/css/default.css"
    id="theme" />
    <!-- End of the headers for CoffeeCup Web Form Builder -->
    <title>
      auto-advies-form
    </title>
  </head>
  
  <body>
    <!-- Start of the body content for CoffeeCup Web Form Builder -->
    <form style="WIDTH: 910px; FONT-SIZE: 12px; WebkitTransform: " id="docContainer"
    class="fb-toplabel fb-100-item-column fb-large selected-object" enctype="multipart/form-data"
    method="post" action="../auto-advies-form.php" novalidate="novalidate"
    data-form="manual_iframe" runat="server">
      <div style="MIN-HEIGHT: 103px" id="fb-form-header1" class="fb-form-header fb-item-alignment-left">
        <a id="fb-link-logo1" class="fb-link-logo" href="" target="_top"><img style="WIDTH: 223px; DISPLAY: inline; HEIGHT: 103px" id="fb-logo1" class="fb-logo" title="Alternative text" alt="Alternative text" src="common/images/foto-allebedrijven.jpg"/></a>
      </div>
      <div id="section1" class="section">
        <div id="column1" class="column ui-sortable">
          <div style="MIN-HEIGHT: 1294px; DISPLAY: none" id="fb_confirm_inline">
          </div>
          <div style="DISPLAY: none" id="fb_error_report">
          </div>
          <div style="FILTER: ; PADDING-BOTTOM: 10px; PADDING-TOP: 6px" id="item3"
          class="fb-item fb-100-item-column">
            <div class="fb-header fb-item-alignment-center">
              <h2 style="DISPLAY: inline; FONT-SIZE: 14px">
                Gebruik onderstaand formulier voor het aanvragen van een Auto-Kennis Auto-Advies
              </h2>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 6px" id="item1" class="fb-item fb-100-item-column">
            <div class="fb-header fb-item-alignment-center">
              <h2 style="DISPLAY: inline; COLOR: #000000; FONT-SIZE: 11px">
                Velden met een ster (*) zijn verplicht
              </h2>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 6px" id="item2" class="fb-item fb-100-item-column">
            <div class="fb-header fb-item-alignment-center">
              <h2 style="DISPLAY: inline; FONT-SIZE: 13px">
                Uw Gegevens 
              </h2>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item5" class="fb-item fb-50-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" for="fullname">Uw Naam*</label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="fullname" MaxLength="254" required="true" placeholder="Voor-letter/-naam + achternaam" runat="server"/>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item6" class="fb-item fb-50-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" for="address">Uw Adres*</label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="address" MaxLength="254" required="true" placeholder="Straat + huisnummer" runat="server"/>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item7" class="fb-item fb-33-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" for="postcode">Postcode*</label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="postcode" MaxLength="254" required="true" placeholder="bijv. 1011AB" runat="server"/>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item8" class="fb-item fb-66-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" for="city">Woonplaats*</label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="city" MaxLength="254" required="true" runat="server"/>
            </div>
          </div>
          <div style="FILTER: ; PADDING-BOTTOM: 10px" id="item12" class="fb-item fb-50-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" for="email">Uw Email-adres*</label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="email" type="email" MaxLength="254" required="true" placeholder="uw-email@adres.nl" runat="server"/>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item10" class="fb-item fb-25-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" for="phoneNumberPrimary">Uw telefoonnummer*</label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="phoneNumberPrimary" required="true" MaxLength="254" runat="server"/>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item11" class="fb-item fb-25-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" for="phoneNumberAlernate">Alternatief telefoonnummer</label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="phoneNumberAlternate" MaxLength="254" runat="server"/>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item14" class="fb-item">
            <div class="fb-sectionbreak">
              <hr>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item15" class="fb-item fb-50-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" for="preferredDate">Gewenste datum Auto-Advies* </label>
            </div>
            <div class="fb-input-date">
              <asp:TextBox id="preferredDate" type="date" CssClass="datepicker" required="true" runat="server"/>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item16" class="fb-item fb-50-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" for="preferredTime">Gewenste tijdstip* </label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="preferredTime" required="true" runat="server"/>
            </div>
          </div>
          <div id="item17" class="fb-item">
            <div class="fb-sectionbreak">
              <hr>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item18" class="fb-item fb-100-item-column">
            <div class="fb-static-text fb-item-alignment-center">
              <p style="COLOR: #000000; FONT-SIZE: 12px; FONT-WEIGHT: bold">
                Gegevens Auto
              </p>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item19" class="fb-item fb-25-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" for="carBrand">Merk*</label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="carBrand" required="true" maxlength="254" runat="server"/>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item20" class="fb-item fb-25-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" for="carModel">Type*</label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="carModel" required="true" maxlength="254" runat="server"/>
            </div>
          </div>
          <div id="item21" class="fb-item fb-25-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" for="carLicensePlate">Kenteken* </label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="carLicensePlate" required="true" maxlength="254" placeholder="bijv. 16-XLJ-3" runat="server"/>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item22" class="fb-item fb-25-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" for="carYear">Bouwjaar*</label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="carYear" required="true" maxlength="254" runat="server"/>
            </div>
          </div>

          <div style="PADDING-BOTTOM: 10px" id="item24" class="fb-item fb-100-item-column">
            <div class="fb-static-text fb-item-alignment-center">
              <p style="COLOR: #000000; FONT-SIZE: 12px; FONT-WEIGHT: bold">
                Gegevens Adres Auto
              </p>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item41" class="fb-item fb-100-item-column">
            <div class="fb-static-text">
              <p style="COLOR: #000000; FONT-SIZE: 12px">
                Alleen in te vullen indien het adres waar de auto ge&iuml;nspecteerd dient
                te worden anders is dan uw eigen adres.
              </p>
            </div>
          </div>

          
            <div style="PADDING-BOTTOM: 10px" id="item25" class="fb-item fb-50-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item25_label_0">Adres Auto</label>
            </div>
            <div class="fb-input-box">
              <input id="item25_text_1" class="" name="Adres-auto" maxlength="254" data-hint=""
              autocomplete="off" placeholder="Straat + huisnummer" type="text" />
            </div>
          </div>
          <div id="item26" class="fb-item fb-25-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item26_label_0">Woonplaats</label>
            </div>
            <div class="fb-input-box">
              <input id="item26_text_1" name="Plaats-auto" maxlength="254" data-hint=""
              autocomplete="off" placeholder="" type="text" />
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item27" class="fb-item fb-25-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item27_label_0">Postcode</label>
            </div>
            <div class="fb-input-box">
              <input id="item27_text_1" class="" name="Postcode-auto" maxlength="254"
              data-hint="" autocomplete="off" placeholder="bijv. 1011AB" type="text"
              />
            </div>
          </div>
          <div id="item33" class="fb-item fb-100-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item33_label_0">Eventuele aanvullende gegevens kunt u hier invullen </label>
            </div>
            <div class="fb-input-box">
              <input id="item33_text_1" name="Opmerkingen" maxlength="254" data-hint=""
              autocomplete="off" placeholder="" type="text" />
            </div>
          </div>
          <div id="item34" class="fb-item">
            <div class="fb-sectionbreak">
              <hr>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item35" class="fb-item fb-100-item-column">
            <div class="fb-static-text fb-item-alignment-center">
              <p style="COLOR: #000000; FONT-SIZE: 12px; FONT-WEIGHT: bold">
                Betaling
              </p>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item36" class="fb-item fb-100-item-column">
            <div class="fb-static-text fb-item-alignment-center">
              <p style="COLOR: #000000; FONT-SIZE: 12px">
                Nadat uw aanvraag bij ons binnen is ontvangt u zo spoedig mogelijk per
                email een overzicht van de kosten. De kosten van een Auto-Kennis Auto-Advies
                bedragen &euro; 89,- excl. toeslagen en de gemaakte kilometerkosten.
              </p>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px; PADDING-LEFT: 4px" id="item37" class="fb-item fb-33-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item37_label_0">Gewenste wijze van betalen* </label>
            </div>
            <div class="fb-dropdown">
              <select id="item37_select_1" name="select37" required data-hint="">
                <option id="item37_0_option" value="" selected>
                  maak uw keuze
                </option>
                <option id="item37_1_option" value="Contant">
                  Contant
                </option>
                <option id="item37_2_option" value="Vooraf per Bank">
                  Vooraf per Bank
                </option>
              </select>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item38" class="fb-item fb-100-item-column">
            <div class="fb-static-text fb-item-alignment-center">
              <p style="COLOR: #000000; FONT-SIZE: 12px">
                Door een afspraak te maken voor een Auto-Kennis Garantie-Keuring verklaart
                u akkoord te gaan met onze algemene voorwaarden welke u op onze website
                kunt inzien.
              </p>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item39" class="fb-item fb-100-item-column fb-side-by-side">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item39_label_0">Klik hier om u akkoord te verklaren met de algemene voorwaarden van Auto-Kennis*</label>
            </div>
            <div style="COLOR: #000000" class="fb-checkbox">
              <label id="item39_0_label"><input id="item39_0_checkbox" name="Akkoord[]" type="checkbox" data-hint="" value="Akkoord" /><span id="item39_0_span" class="fb-fieldlabel">Akkoord</span></label>
            </div>
          </div>
          <div style="FILTER: ; PADDING-BOTTOM: 12px" id="item40" class="fb-item fb-100-item-column">
            <div class="fb-static-text fb-item-alignment-center">
              <p style="COLOR: #000000; FONT-SIZE: 11px">
                Auto-Kennis handelt overeenkomstig de Wet bescherming persoonsgegevens.
                Gegevens door u verstrekt worden strikt vertrouwelijk behandeld en niet
                aan derden verstrekt.
              </p>
            </div>
          </div>
        </div>
      </div>
      <div style="MIN-HEIGHT: 1px" id="fb-submit-button-div" class="fb-footer fb-item-alignment-center">
        <asp:Button
            id="submitButton"
            runat="server"
            Text="Verzenden"
            OnClick="submitButtonClicked"
            class="fb-button-special"
            style="BACKGROUND-IMAGE: url(theme/default/images/btn_submit.png)"
         />
      </div>
    </form>
    <!-- End of the body content for CoffeeCup Web Form Builder -->
  </body>

</html>
