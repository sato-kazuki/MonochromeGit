using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

/// <summary>
/// 唯一UnityEngineを使わないNetwork周りを直接管理するスクリプト
/// </summary>
public class NetworkManager {

    static int LOCAL_PORT = 3333;
    static UdpClient udp;
    static Thread thread;
    //

    static string host = "192.168.11.7";
    static int port = 3333;
    static UdpClient client;

//    static UdpClient UDPClient;

    /// <summary>
    /// 通信初期化式
    /// </summary>
    static public void UDPThreadStart()
    {
        udp = new UdpClient(LOCAL_PORT);
        udp.Client.ReceiveTimeout = 30000;

        client = new UdpClient();
        client.Connect(host, port);

        //timeoutの時間(ms)設定　timeout時に処理走らせる方法は要検索
        thread = new Thread(new ThreadStart(ThreadMethod));
        //受信したbyteの送り先を登録しておく必要も有?
        thread.Start();
    }
    /// <summary>
    /// 送信専用
    /// </summary>
    static public void KeyByteTransmission(byte[] transmissionByte)
    {
        client.Send(transmissionByte, transmissionByte.Length);
    }

    /// <summary>
    /// 使うかわかんないけどIP取得用
    /// </summary>
    /// <returns></returns>
    static public string CheckIP()
    {
        // ホスト名を取得する
        string hostname = Dns.GetHostName();
        string returnAddress ="";
        // ホスト名からIPアドレスを取得する
        IPAddress[] adrList = Dns.GetHostAddresses(hostname);
        foreach (IPAddress address in adrList)
        {
            //UDPClient.instance.host = address.ToString();
            returnAddress += address.ToString();
        }
        return returnAddress;
        
    }
    
    /// <summary>
    /// 受信機構本体
    /// </summary>
    private byte[] UDPReceptioner()
    {
        byte[] receptBytes = { 1, 2 };
        return receptBytes;
    }

    /// <summary>
    /// 通信用スレッドメソッド
    /// </summary>
    private static void ThreadMethod()
    {
        while (true)
        {
            IPEndPoint remoteEP = null;
            byte[] data = udp.Receive(ref remoteEP);
        }
    }
    /// <summary>
    /// 通信終了
    /// </summary>
    static public void CloseUDPThread()
    {
        NetworkManager.client.Close();
        thread.Abort();
    }
}
