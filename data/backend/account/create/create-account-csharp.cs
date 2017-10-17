using System;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text;

namespace MyNamespace {
	public class MyActivity {

		private async Task<bool> Createaccount () {

			string url = "https://filethis.com/api/v1/accounts";

			HttpWebRequest request = (HttpWebRequest)WebRequest.Create (new Uri(url));
			request.ContentType = "text/plain; charset=utf-8";
			request.Headers.Add("Authorization", "Basic czkyaHRwa3A5ajE5Y3NyaTlhN2hwYzhtcDprNm5kZzl2OWU4anQ3ZTRuNHRkOW9oMGV1ZQ==");

			request.Method = "POST";

			string postData = "{\n  \"partnerAccountId\": \"2d8b58f1-aaa0-48a6-a48a-740e4f4203e2\"\n}";
			ASCIIEncoding encoding = new ASCIIEncoding ();
			byte[] byte1 = encoding.GetBytes (postData);
			request.ContentLength = byte1.Length;
			Stream newStream = request.GetRequestStream ();
			newStream.Write (byte1, 0, byte1.Length);
			newStream.Close ();

			using (WebResponse response = await request.GetResponseAsync ()) {
				using (Stream stream = response.GetResponseStream ()) {
					return true;
					//process the response
				}
			}
		}
	}
}
