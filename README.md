## FIDO2 Sample

參考自: https://github.com/passwordless-lib/fido2-net-lib#examples

## 參數
### userVerification (使用者驗證要求)
https://w3c.github.io/webauthn/#user-verification
https://w3c.github.io/webauthn/#enumdef-userverificationrequirement
	- required (要求使用者驗證)
	- preferred (根據使用者安全性設定來驗證，使用有設定 PIN碼 or 指紋)
	- discouraged (在操作期間不要求驗證，但當使用有使用實體金鑰 or 生物辯證驗證，此時仍會驗證)
### requireResidentKey (是否要求金鑰常駐在客戶端)
	- true (是) PS 測試 Windwos Hello Pin (若當 Pin 移除，則常駐金鑰也會移除)
	- false (否)
https://w3c.github.io/webauthn/#dom-authenticatorselectioncriteria-requireresidentkey

## 流程
1. 註冊裝置
	1.1 /makeCredentialOptions (打後端API 取得憑證參數)
	1.2  navigator.credentials.create (Web API 建立憑證)
	1.3 /makeCredential (打後端API 儲存憑證)

2. 登入
	2.1 /assertionOptions (打後端API 先驗證帳號是否存在，並回傳憑證參數)
	2.2 navigator.credentials.get (Web API 取得憑證)
	2.3 /makeAssertion (將憑證傳回後端驗證)
