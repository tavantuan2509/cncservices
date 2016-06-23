
package CNCServices;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.6-1b01 
 * Generated source version: 2.2
 * 
 */
@WebService(name = "SoftpinSoap", targetNamespace = "http://tempuri.org/")
@XmlSeeAlso({
    ObjectFactory.class
})
public interface SoftpinSoap {


    /**
     * 
     * @param data
     * @param agentCode
     * @return
     *     returns java.lang.String
     */
    @WebMethod(operationName = "BuyCard", action = "http://tempuri.org/BuyCard")
    @WebResult(name = "BuyCardResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "BuyCard", targetNamespace = "http://tempuri.org/", className = "CNCServices.BuyCard")
    @ResponseWrapper(localName = "BuyCardResponse", targetNamespace = "http://tempuri.org/", className = "CNCServices.BuyCardResponse")
    public String buyCard(
        @WebParam(name = "agentCode", targetNamespace = "http://tempuri.org/")
        String agentCode,
        @WebParam(name = "data", targetNamespace = "http://tempuri.org/")
        String data);

    /**
     * 
     * @param data
     * @param agentCode
     * @return
     *     returns java.lang.String
     */
    @WebMethod(operationName = "GetCard", action = "http://tempuri.org/GetCard")
    @WebResult(name = "GetCardResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "GetCard", targetNamespace = "http://tempuri.org/", className = "CNCServices.GetCard")
    @ResponseWrapper(localName = "GetCardResponse", targetNamespace = "http://tempuri.org/", className = "CNCServices.GetCardResponse")
    public String getCard(
        @WebParam(name = "agentCode", targetNamespace = "http://tempuri.org/")
        String agentCode,
        @WebParam(name = "data", targetNamespace = "http://tempuri.org/")
        String data);

    /**
     * 
     * @param data
     * @param agentCode
     * @return
     *     returns java.lang.String
     */
    @WebMethod(operationName = "Topup", action = "http://tempuri.org/Topup")
    @WebResult(name = "TopupResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "Topup", targetNamespace = "http://tempuri.org/", className = "CNCServices.Topup")
    @ResponseWrapper(localName = "TopupResponse", targetNamespace = "http://tempuri.org/", className = "CNCServices.TopupResponse")
    public String topup(
        @WebParam(name = "agentCode", targetNamespace = "http://tempuri.org/")
        String agentCode,
        @WebParam(name = "data", targetNamespace = "http://tempuri.org/")
        String data);

    /**
     * 
     * @param data
     * @param agentCode
     * @return
     *     returns java.lang.String
     */
    @WebMethod(operationName = "CheckTranTopup", action = "http://tempuri.org/CheckTranTopup")
    @WebResult(name = "CheckTranTopupResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "CheckTranTopup", targetNamespace = "http://tempuri.org/", className = "CNCServices.CheckTranTopup")
    @ResponseWrapper(localName = "CheckTranTopupResponse", targetNamespace = "http://tempuri.org/", className = "CNCServices.CheckTranTopupResponse")
    public String checkTranTopup(
        @WebParam(name = "agentCode", targetNamespace = "http://tempuri.org/")
        String agentCode,
        @WebParam(name = "data", targetNamespace = "http://tempuri.org/")
        String data);

    /**
     * 
     * @param agentcode
     * @param data
     * @return
     *     returns java.lang.String
     */
    @WebMethod(operationName = "CheckCount", action = "http://tempuri.org/CheckCount")
    @WebResult(name = "CheckCountResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "CheckCount", targetNamespace = "http://tempuri.org/", className = "CNCServices.CheckCount")
    @ResponseWrapper(localName = "CheckCountResponse", targetNamespace = "http://tempuri.org/", className = "CNCServices.CheckCountResponse")
    public String checkCount(
        @WebParam(name = "agentcode", targetNamespace = "http://tempuri.org/")
        String agentcode,
        @WebParam(name = "data", targetNamespace = "http://tempuri.org/")
        String data);

}
