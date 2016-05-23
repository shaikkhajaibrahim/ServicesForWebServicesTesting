import com.eviware.soapui.support.GroovyUtils;
import com.eviware.soapui.support.types.StringToStringsMap;

StringToStringsMap headers = mockRequest.getReqeustHeaders();
log.info("Request Headers are...\n");
headers.each
{
  log.info(it.key + ": " + it.value + "\n");
}
log.info("\n");

log.info("Request Content is...\n");
log.info(mockRequest.getRequestContent);