// Usernameless

註冊
1. /makeCredentialOptions (打後端API 取得憑證參數)

req
```json
{
    "displayName": "Leo",
    "attType": "none",
    "authType": "",
    "userVerification": "preferred",
    "requireResidentKey": "true"
}
```

res
```json
{
    "rp": {
      "id": "localhost",
      "name": "FIDO2 Test"
    },
    "user": {
      "name": "Leo (Usernameless user created at 2023/9/19 上午 08:34:54)",
      "id": "TGVvIChVc2VybmFtZWxlc3MgdXNlciBjcmVhdGVkIGF0IDIwMjMvOS8xOSDkuIrljYggMDg6MzQ6NTQp",
      "displayName": "Leo"
    },
    "challenge": "pOzVsuV-vhXaE91Ej1XSrg",
    "pubKeyCredParams": [
      {
        "type": "public-key",
        "alg": -7
      },
      {
        "type": "public-key",
        "alg": -257
      },
      {
        "type": "public-key",
        "alg": -37
      },
      {
        "type": "public-key",
        "alg": -35
      },
      {
        "type": "public-key",
        "alg": -258
      },
      {
        "type": "public-key",
        "alg": -38
      },
      {
        "type": "public-key",
        "alg": -36
      },
      {
        "type": "public-key",
        "alg": -259
      },
      {
        "type": "public-key",
        "alg": -39
      },
      {
        "type": "public-key",
        "alg": -8
      }
    ],
    "timeout": 60000,
    "attestation": "none",
    "authenticatorSelection": {
      "requireResidentKey": true,
      "userVerification": "preferred"
    },
    "excludeCredentials": [
      
    ],
    "extensions": {
      "exts": true,
      "uvm": true
    },
    "status": "ok",
    "errorMessage": ""
}
```

2. navigator.credentials.create({
    publicKey: req
}) (Web API 建立憑證)

req
```json
{
    "rp": {
      "id": "localhost",
      "name": "FIDO2 Test"
    },
    "user": {
      "name": "Leo (Usernameless user created at 2023/9/19 上午 08:34:54)",
      "id": {
        
      },
      "displayName": "Leo"
    },
    "challenge": {
      
    },
    "pubKeyCredParams": [
      {
        "type": "public-key",
        "alg": -7
      },
      {
        "type": "public-key",
        "alg": -257
      },
      {
        "type": "public-key",
        "alg": -37
      },
      {
        "type": "public-key",
        "alg": -35
      },
      {
        "type": "public-key",
        "alg": -258
      },
      {
        "type": "public-key",
        "alg": -38
      },
      {
        "type": "public-key",
        "alg": -36
      },
      {
        "type": "public-key",
        "alg": -259
      },
      {
        "type": "public-key",
        "alg": -39
      },
      {
        "type": "public-key",
        "alg": -8
      }
    ],
    "timeout": 60000,
    "attestation": "none",
    "authenticatorSelection": {
      "requireResidentKey": true,
      "userVerification": "preferred"
    },
    "excludeCredentials": [
      
    ],
    "extensions": {
      "exts": true,
      "uvm": true
    },
    "status": "ok",
    "errorMessage": ""
}
```

res
```json
{
    "authenticatorAttachment": "platform",
    "id": "VIhipPBeNlzo2nZp11oL1XrODg0Wn9AaEw213dVqHaY",
    "rawId": ArrayBuffer
    "response" {
        "attestationObject": ArrayBuffer,
        "clientDataJSON" ArrayBuffer,
    },
    "type": "public-key"
}
```

3. /makeCredential (打後端API 儲存憑證)

req
```json
{
    "id": "VIhipPBeNlzo2nZp11oL1XrODg0Wn9AaEw213dVqHaY",
    "rawId": "VIhipPBeNlzo2nZp11oL1XrODg0Wn9AaEw213dVqHaY",
    "type": "public-key",
    "extensions": {
      
    },
    "response": {
      "attestationObject": "o2NmbXRkbm9uZWdhdHRTdG10oGhhdXRoRGF0YVkBZ0mWDeWIDoxodDQXD2R2YFuP5K65ooYyx5lc87qDHZdjRQAAAAAAAAAAAAAAAAAAAAAAAAAAACBUiGKk8F42XOjadmnXWgvVes4ODRaf0BoTDbXd1WodpqQBAwM5AQAgWQEA1PR-mB36TBk_H3EAdDb5zFIts4z6t2HBzVqvp2rOBYcS4wdO5c_hgRHauw8tZrT6IQfcYzxa7tBmlg534Y1LwxwgNLHg81BW5xmiD2FPbWvM_bXKyGXWcvyxce_Mz9Bf5gnNLIjdDq5_3L3NLPxiLi-k56OGwbmNlEytxrDBfXbbQAX2BmbFABRw4k4Umb6Bm-bBDp_Ig3s2oJO-gmQ2P8BrE3oPtR2IXeCvwe2erlJzq6YRB_y-aacsn_Ph2sF31dDCsWbsS0NzV4M9uSPVtjlAnBndGYG-TKkVv-ymlzvH_0wpNRI6L4MVhEGAk3F-jYkYHP0fGABhZ3YPiYfFzSFDAQAB",
      "clientDataJSON": "eyJ0eXBlIjoid2ViYXV0aG4uY3JlYXRlIiwiY2hhbGxlbmdlIjoieXNfa2l6UUlTMmotUHh6M29vTEhJdyIsIm9yaWdpbiI6Imh0dHBzOi8vbG9jYWxob3N0OjcxODAiLCJjcm9zc09yaWdpbiI6ZmFsc2V9"
    }
}
```

res
```json
{
    "result": {
      "publicKey": "pAEDAzkBACBZAQDU9H6YHfpMGT8fcQB0NvnMUi2zjPq3YcHNWq-nas4FhxLjB07lz-GBEdq7Dy1mtPohB9xjPFru0GaWDnfhjUvDHCA0seDzUFbnGaIPYU9ta8z9tcrIZdZy_LFx78zP0F_mCc0siN0Orn_cvc0s_GIuL6Tno4bBuY2UTK3GsMF9dttABfYGZsUAFHDiThSZvoGb5sEOn8iDezagk76CZDY_wGsTeg-1HYhd4K_B7Z6uUnOrphEH_L5ppyyf8-HawXfV0MKxZuxLQ3NXgz25I9W2OUCcGd0Zgb5MqRW_7KaXO8f_TCk1EjovgxWEQYCTcX6NiRgc_R8YAGFndg-Jh8XNIUMBAAE",
      "user": {
        "name": "Leo (Usernameless user created at 2023/9/19 上午 08:37:27)",
        "id": "TGVvIChVc2VybmFtZWxlc3MgdXNlciBjcmVhdGVkIGF0IDIwMjMvOS8xOSDkuIrljYggMDg6Mzc6Mjcp",
        "displayName": "Leo"
      },
      "credType": "none",
      "aaguid": "00000000-0000-0000-0000-000000000000",
      "attestationCertificate": null,
      "attestationCertificateChain": [
        
      ],
      "credentialId": "VIhipPBeNlzo2nZp11oL1XrODg0Wn9AaEw213dVqHaY=",
      "counter": 0,
      "status": null,
      "errorMessage": null
    },
    "status": "ok",
    "errorMessage": ""
}
```

登入
1. /assertionOptions (打後端API 先驗證帳號是否存在，並回傳憑證參數)

req
```json
{

}
```

res
```json
{
    "challenge": "AS2kFwnN_gMbW2k_yyul1w",
    "timeout": 60000,
    "rpId": "localhost",
    "allowCredentials": [
      
    ],
    "userVerification": "discouraged",
    "extensions": {
      "exts": true,
      "uvm": true
    },
    "status": "ok",
    "errorMessage": ""
}
```

2. navigator.credentials.get({
    publicKey: req
}) (Web API 取得憑證)

req
```json
{
    "challenge": {
      "0": 1,
      "1": 45,
      "2": 164,
      "3": 23,
      "4": 9,
      "5": 205,
      "6": 254,
      "7": 3,
      "8": 27,
      "9": 91,
      "10": 105,
      "11": 63,
      "12": 203,
      "13": 43,
      "14": 165,
      "15": 215
    },
    "timeout": 60000,
    "rpId": "localhost",
    "allowCredentials": [
      
    ],
    "userVerification": "discouraged",
    "extensions": {
      "exts": true,
      "uvm": true
    },
    "status": "ok",
    "errorMessage": ""
}
```

res
```json
{
    "authenticatorAttachment": null,
    "id": "VIhipPBeNlzo2nZp11oL1XrODg0Wn9AaEw213dVqHaY",
    "rawId": ArrayBuffer,
    "response": {
        "authenticatorData": ArrayBuffer,
        "clientDataJSON": ArrayBuffer,
        "signature": ArrayBuffer,
        "userHandle": ArrayBuffer
    },
    "type": "public-key"
}
```

3. /makeAssertion (將憑證傳回後端驗證)

req
```json
{
    "id": "VIhipPBeNlzo2nZp11oL1XrODg0Wn9AaEw213dVqHaY",
    "rawId": "VIhipPBeNlzo2nZp11oL1XrODg0Wn9AaEw213dVqHaY",
    "type": "public-key",
    "extensions": {
      
    },
    "response": {
      "authenticatorData": "SZYN5YgOjGh0NBcPZHZgW4_krrmihjLHmVzzuoMdl2MFAAAAAg",
      "clientDataJSON": "eyJ0eXBlIjoid2ViYXV0aG4uZ2V0IiwiY2hhbGxlbmdlIjoiLVVmMHk5bFBiWlhrVlFUbl9JZTUzUSIsIm9yaWdpbiI6Imh0dHBzOi8vbG9jYWxob3N0OjcxODAiLCJjcm9zc09yaWdpbiI6ZmFsc2UsIm90aGVyX2tleXNfY2FuX2JlX2FkZGVkX2hlcmUiOiJkbyBub3QgY29tcGFyZSBjbGllbnREYXRhSlNPTiBhZ2FpbnN0IGEgdGVtcGxhdGUuIFNlZSBodHRwczovL2dvby5nbC95YWJQZXgifQ",
      "userHandle": "TGVvIChVc2VybmFtZWxlc3MgdXNlciBjcmVhdGVkIGF0IDIwMjMvOS8xOSDkuIrljYggMDg6Mzc6Mjcp",
      "signature": "AkrKCz_PWa8cfr_SOpxJHajuXdgRLkNKXruW8RVAbxOedbNwnQFR-9e_CxwnTEyTOll25UFHOtN3U60cfE9W7midRm5R_I6mgTWL4DrMMVDeAVMpCqcSul4wiZo7dqPAHZ27uAujHH1GOoU7d3xbLqjApanzzSPRRMI9NuQJlcTz7l2b7tvpS23GUnv2fXtybSxrgEeodzFwS5ZeyR81CiIpjRFDEILCEHNaxlfQ0pWfLC2eV9lpk7lRTHFNKJ3P4Zsb-1EXy3F9DR1GgSd_AjEWRUku13NtbLx11fonfDZxFS3wHSsYNV1ajalJ6J3HYAzd0lHSyHusy6JQjwUNaQ"
    }
}
```

res
```json
{
    "credentialId": "VIhipPBeNlzo2nZp11oL1XrODg0Wn9AaEw213dVqHaY=",
    "counter": 2,
    "status": "ok",
    "errorMessage": ""
}
```