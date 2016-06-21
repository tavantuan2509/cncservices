
package CNCServices;

import java.net.MalformedURLException;
import java.net.URL;
import javax.xml.namespace.QName;
import javax.xml.ws.Service;
import javax.xml.ws.WebEndpoint;
import javax.xml.ws.WebServiceClient;
import javax.xml.ws.WebServiceException;
import javax.xml.ws.WebServiceFeature;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.6-1b01 
 * Generated source version: 2.2
 * 
 */
@WebServiceClient(name = "Softpin", targetNamespace = "http://tempuri.org/", wsdlLocation = "http://testpay.pay365.vn/Softpin.asmx?WSDL")
public class Softpin
    extends Service
{

    private final static URL SOFTPIN_WSDL_LOCATION;
    private final static WebServiceException SOFTPIN_EXCEPTION;
    private final static QName SOFTPIN_QNAME = new QName("http://tempuri.org/", "Softpin");

    static {
        URL url = null;
        WebServiceException e = null;
        try {
            url = new URL("http://testpay.pay365.vn/Softpin.asmx?WSDL");
        } catch (MalformedURLException ex) {
            e = new WebServiceException(ex);
        }
        SOFTPIN_WSDL_LOCATION = url;
        SOFTPIN_EXCEPTION = e;
    }

    public Softpin() {
        super(__getWsdlLocation(), SOFTPIN_QNAME);
    }

    public Softpin(WebServiceFeature... features) {
        super(__getWsdlLocation(), SOFTPIN_QNAME, features);
    }

    public Softpin(URL wsdlLocation) {
        super(wsdlLocation, SOFTPIN_QNAME);
    }

    public Softpin(URL wsdlLocation, WebServiceFeature... features) {
        super(wsdlLocation, SOFTPIN_QNAME, features);
    }

    public Softpin(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public Softpin(URL wsdlLocation, QName serviceName, WebServiceFeature... features) {
        super(wsdlLocation, serviceName, features);
    }

    /**
     * 
     * @return
     *     returns SoftpinSoap
     */
    @WebEndpoint(name = "SoftpinSoap")
    public SoftpinSoap getSoftpinSoap() {
        return super.getPort(new QName("http://tempuri.org/", "SoftpinSoap"), SoftpinSoap.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns SoftpinSoap
     */
    @WebEndpoint(name = "SoftpinSoap")
    public SoftpinSoap getSoftpinSoap(WebServiceFeature... features) {
        return super.getPort(new QName("http://tempuri.org/", "SoftpinSoap"), SoftpinSoap.class, features);
    }

    /**
     * 
     * @return
     *     returns SoftpinSoap
     */
    @WebEndpoint(name = "SoftpinSoap12")
    public SoftpinSoap getSoftpinSoap12() {
        return super.getPort(new QName("http://tempuri.org/", "SoftpinSoap12"), SoftpinSoap.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns SoftpinSoap
     */
    @WebEndpoint(name = "SoftpinSoap12")
    public SoftpinSoap getSoftpinSoap12(WebServiceFeature... features) {
        return super.getPort(new QName("http://tempuri.org/", "SoftpinSoap12"), SoftpinSoap.class, features);
    }

    private static URL __getWsdlLocation() {
        if (SOFTPIN_EXCEPTION!= null) {
            throw SOFTPIN_EXCEPTION;
        }
        return SOFTPIN_WSDL_LOCATION;
    }

}
