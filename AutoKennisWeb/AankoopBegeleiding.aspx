<%@ Page Language="C#" Inherits="AutoKennisWeb.AankoopBegeleiding" %>
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
      aankoop-begeleiding-form
    </title>
  </head>
  
  <body>
    <!-- Start of the body content for CoffeeCup Web Form Builder -->
     <form runat="server" style="WIDTH: 910px; FONT-SIZE: 12px; WebkitTransform: " id="docContainer"
    class="fb-toplabel fb-100-item-column fb-large selected-object" enctype="multipart/form-data"
    method="post" action="AankoopBegeleiding.aspx"
    data-form="manual_iframe">
      <div style="MIN-HEIGHT: 103px" id="fb-form-header1" class="fb-form-header fb-item-alignment-left">
        <a id="fb-link-logo1" class="fb-link-logo" href="" target="_top"><img style="WIDTH: 223px; DISPLAY: inline; HEIGHT: 103px" id="fb-logo1" class="fb-logo" title="Alternative text" alt="Alternative text" src="common/images/foto-allebedrijven.jpg"/></a>
      </div>
      <div id="section1" class="section">
        <div id="column1" class="column ui-sortable">
          <div style="MIN-HEIGHT: 1335px; DISPLAY: none" id="fb_confirm_inline">
          </div>
          <div style="DISPLAY: none" id="fb_error_report">
          </div>
          <div style="FILTER: ; PADDING-BOTTOM: 10px; PADDING-TOP: 6px" id="item3"
          class="fb-item fb-100-item-column">
            <div class="fb-header fb-item-alignment-center">
              <h2 style="DISPLAY: inline; FONT-SIZE: 14px">
                Gebruik onderstaand formulier voor het aanvragen van een Auto-Kennis Aankoop-Begeleiding
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
              <label style="DISPLAY: inline" for="preferredDate">Gewenste datum Aankoop-Begeleiding* </label>
            </div>
            <div class="fb-input-date">
              <asp:TextBox id="preferredDate" type="date" CssClass="datepicker" required="true" runat="server"/>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item16" class="fb-item fb-50-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" for="preferredTime">Gewenste tijdstip* (voorbeeld 13:30)</label>
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
              <label style="DISPLAY: inline" id="item19_label_0">Merk*</label>
            </div>
            <div class="fb-input-box">
              <asp:Textbox id="carBrand" name="MerkAuto" maxlength="254" placeholder=""
              autocomplete="off" data-hint="" required type="text" runat="server" />
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item20" class="fb-item fb-25-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item20_label_0">Type*</label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="carType" name="Type" maxlength="254" placeholder="" autocomplete="off"
              data-hint="" required type="text" runat="server"/>
            </div>
          </div>
          <div id="item21" class="fb-item fb-25-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item21_label_0">Kenteken* </label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="carLicencePlate" class="" name="Kenteken" maxlength="254" placeholder="bijv. 16-XLJ-3"
              autocomplete="off" data-hint="" required type="text" runat="server"/>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item22" class="fb-item fb-25-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item22_label_0">Bouwjaar*</label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="carYear" name="text22" maxlength="254" placeholder=""
              autocomplete="off" data-hint="" type="text" runat="server"/>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item24" class="fb-item fb-100-item-column">
            <div class="fb-static-text fb-item-alignment-center">
              <p style="COLOR: #000000; FONT-SIZE: 12px; FONT-WEIGHT: bold">
                Gegevens verkoper auto
              </p>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item25" class="fb-item fb-50-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item25_label_0">Adres Auto*</label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="carAddress" class="" name="Adres-auto" maxlength="254" placeholder="Straat + huisnummer"
              autocomplete="off" data-hint="" required type="text" runat="server"/>
            </div>
          </div>
          <div id="item26" class="fb-item fb-25-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item26_label_0">Woonplaats*</label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="carCity" name="Plaats-auto" maxlength="254" placeholder=""
              autocomplete="off" data-hint="" required type="text" runat="server"/>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item27" class="fb-item fb-25-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item27_label_0">Postcode*</label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="carPostcode" class="" name="Postcode-auto" maxlength="254"
              placeholder="bijv. 1011AB" autocomplete="off" data-hint="" type="text" runat="server"
              />
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item28" class="fb-item fb-25-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item28_label_0">Telefoon verkoper*</label>
            </div>
            <div class="fb-phone">
              <asp:TextBox id="sellerPhoneNumber" name="telefoon-verkoper" data-hint="" required
              type="tel" runat="server"/>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item29" class="fb-item fb-33-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item29_label_0">Verkoper is Particulier / bedrijf</label>
            </div>
            <div class="fb-dropdown">
              <select id="sellerType" name="particulierbedrijf" data-hint="" required>
                <option id="item29_0_option" value="" selected>
                  maak uw keuze
                </option>
                <option id="item29_1_option" value="bedrijf">
                  bedrijf
                </option>
                <option id="item29_2_option" value="particulier">
                  particulier
                </option>
              </select>
            </div>
            <div style="FONT-STYLE: normal; COLOR: #888; FONT-WEIGHT: normal" class="fb-hint">
              Geef hier aan of de verkoper particulier of bedrijf is
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px" id="item31" class="fb-item fb-33-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item31_label_0">Vraagprijs Auto</label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="carPrice" name="auto-price" maxlength="254" placeholder=""
              autocomplete="off" data-hint="" type="text" runat="server" />
            </div>
          </div>
          <div id="item33" class="fb-item fb-100-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item33_label_0">Eventuele aanvullende gegevens kunt u hier invullen </label>
            </div>
            <div class="fb-input-box">
              <asp:TextBox id="comments" name="Opmerkingen" maxlength="254" placeholder=""
              autocomplete="off" data-hint="" type="text" runat="server"/>
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
                email een overzicht van de kosten. De kosten van een Auto-Kennis Aankoop-Bemiddeling
                bemiddeling bedragen &euro; 199,- excl. de gemaakte kilometerkosten.
              </p>
            </div>
          </div>
          <div style="PADDING-BOTTOM: 10px; PADDING-LEFT: 4px" id="item37" class="fb-item fb-33-item-column">
            <div class="fb-grouplabel">
              <label style="DISPLAY: inline" id="item37_label_0">Gewenste wijze van betalen* </label>
            </div>
            <div class="fb-dropdown">
              <select id="paymentMethod" name="paymentMethod" data-hint="" required>
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
                Door een afspraak te maken voor een Auto-Kennis Aankoop-Keuring verklaart
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
              <label id="item39_0_label"><input id="item39_0_checkbox" name="Akkoord[]" type="checkbox" data-hint="" value="Akkoord" required="required"/><span id="item39_0_span" class="fb-fieldlabel">Akkoord</span></label>
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
        <input id="fb-submit-button" class="fb-button-special" type="submit" data-regular=""
        value="Verzenden" />
      </div>
      <input name="fb_form_custom_html" type="hidden" />
      <input name="fb_form_embedded" type="hidden" />
      <input id="fb_js_enable" name="fb_js_enable" type="hidden" />
    </form>
    <!-- End of the body content for CoffeeCup Web Form Builder -->
  </body>

</html>
