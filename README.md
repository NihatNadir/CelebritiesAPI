# CelebritiesAPI

## Celebrity Modeli

![image](https://github.com/user-attachments/assets/fd1f9338-1cab-4819-b24d-43ca8840554e)


## CelebritiesController 

### static liste

![image](https://github.com/user-attachments/assets/d67deed0-892a-44dc-aa10-3eeb4aeb91ea)


## Http Yöntemleri

- [HttpGet("{id}")] : Listede istenen Id olan çağırılır. Nesne bulunursa Id sahip nesne döner 200 bulunamazsa 404 NotFound

![image](https://github.com/user-attachments/assets/c1d1cf1f-b073-4da4-9a24-46fddcd731c8)

  
- [HttpPost] : Listeye yeni bir nesne eklenir.

![image](https://github.com/user-attachments/assets/0488d421-ca80-4136-bcdb-2b09680d1d0e)

  
- [HttpPut("{id}")] : Listede güncellemek istenen Id girilir. Listede girilen Id yoksa 404 Not Found döner. Id listede yer alıyorsa body kısmından veriler değiştirilir ve geriye 204 No Content döner.

![image](https://github.com/user-attachments/assets/a871d2a5-a0a6-43ba-8864-0b86f53a9606)

  
- [HttpDelete("{id}")] : Listede silinmek istenen Id girilir. Eğer listede Id yoksa 404 Not Found döner. Id listede yer alıyorsa nesne listeden silinir ve geriye 204 No Content döner.

  ![image](https://github.com/user-attachments/assets/250bd626-e8fb-499e-8dbd-8bcfe6e2245b)


