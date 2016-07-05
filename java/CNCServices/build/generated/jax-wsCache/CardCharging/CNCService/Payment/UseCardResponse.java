
package CNCService.Payment;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for anonymous complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="UseCardResult" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "useCardResult"
})
@XmlRootElement(name = "UseCardResponse")
public class UseCardResponse {

    @XmlElement(name = "UseCardResult")
    protected String useCardResult;

    /**
     * Gets the value of the useCardResult property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getUseCardResult() {
        return useCardResult;
    }

    /**
     * Sets the value of the useCardResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setUseCardResult(String value) {
        this.useCardResult = value;
    }

}
