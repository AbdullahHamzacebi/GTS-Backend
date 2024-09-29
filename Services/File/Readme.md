## File Service Dizin Yap�s� 

### GTSProject.Services.File  
??? **Controllers**  
?   ??? UploadFilesController.cs  
??? **DbSettings**  
?   ??? **Context**  
?   ?   ??? MongoDbContext.cs  
?   ?   ??? MssqlDbContext.cs  
??? **Dtos**  
?   ??? **RequestDtos**  
?   ?   ??? **UploadFileRequestDtos**  
?   ?   ?   ??? CreateMultipleUploadFileRequestDto.cs  
?   ?   ?   ??? CreateUploadFileRequestDto.cs  
?   ?   ?   ??? DeleteUploadFileRequestDto.cs  
?   ?   ?   ??? ResultGetAllUploadFileMongoRequestDto.cs  
?   ?   ?   ??? ResultGetAllUploadFileMssqlRequestDto.cs  
?   ?   ?   ??? ResultGetByIdUploadFileRequestDto.cs  
?   ?   ??? **UploadFileDtos**  
?   ?   ?   ??? CreateUploadFileDto.cs  
?   ?   ?   ??? UpdateUploadFileDto.cs  
?   ?   ?   ??? ResultUploadFileDto.cs  
?   ?   ?   ??? GetByIdUploadFileDto.cs  
??? **Entities**  
?   ??? UploadFile.cs  
??? **Mapping**  
?   ??? GeneralMapping.cs  
??? **PublicFolder**  
?   ??? **ResultTools**  
?   ?   ??? DataResult.cs  
?   ?   ??? ErrorDataResult.cs  
?   ?   ??? ErrorResult.cs  
?   ?   ??? IDataResult.cs  
?   ?   ??? IResult.cs  
?   ?   ??? Result.cs  
?   ?   ??? SuccessDataResult.cs  
?   ?   ??? SuccessResult.cs  
??? **Repositories**  
?   ??? **RepositoryFactories**  
?   ?   ??? RepositoryFactory.cs  
?   ??? **UploadFileRepositories**  
?   ?   ??? IUploadFileRepository.cs  
?   ?   ??? MongoUploadFileRepository.cs  
?   ?   ??? MssqlUploadFileRepository.cs  
??? **Services**  
?   ??? **UploadFileServices**  
?   ?   ??? IUploadFileService.cs  
?   ?   ??? UploadFileService.cs  
??? **wwwroot**  
?   ??? **Uploads**  
?       ??? MongoUpload  
?       ??? MssqlUpload  


File Service dosya y�netimi i�levlerini mikroservis mimarisi prensiplerine uygun ger�ekle�tiren, mod�ler, esnek ve �l�eklenebilir bir yap� sunar. 
Farkl� veri kaynaklar� (MongoDB ve MSSQL) ile �al��abilme �zelli�ine sahiptir ve bu yap�lar aras�nda ge�i� yapabilecek �ekilde tasarlanm��t�r.

?? **Dosya Y�kleme ve Y�netimi**
??Ekleme, silme, listeleme, g�ncelleme gibi t�m dosya y�netimi i�lemlerini destekler.
??Dosyalar, ilgili meta veriler ile birlikte veritaban�nda saklan�r.

?? **Mod�ler Servis Katman�**
??MSSQL taraf�nda Entity Framework kullan�l�r ve bu sayede ili�kisel veritaban� i�lemleri yap�l�r.
??MongoDB taraf�nda ise NoSQL i�lemlerini destekleyen bir yap� vard�r. MongoDB i�in ayr� bir MongoDbContext ve repository bulunmaktad�r.

?? **Repository Design Pattern**
??Veritaban� i�lemlerini soyutlayarak veri eri�imini mod�ler hale getirmek ve i� mant���ndan ay�rmak.
??Projede hem MSSQL hem de MongoDB i�in farkl� repository'ler olu�turulmu�tur:

?? **Factory Design Pattern**
??Hangi veri kayna��yla (MSSQL veya MongoDB) �al���laca��na runtime'da karar verebilmek. Bu sayede uygulama, farkl� ortamlara g�re yap�land�r�labilir.
?? Factory yap�s�, istenilen veritaban�na g�re ilgili repository�yi sa�lar.

?? **DTO (Data Transfer Object) Yap�s�**
??Dosya transfer modelleri, veriyi d�� d�nyaya ta��mak i�in kullan�l�r. Bu sayede veriler izole edilmi� ve i� mant��� katman�nda karma��kl�k en aza indirilmi�tir.

?? **AutoMapper**
??Veri transfer nesnelerini i� mant��� katman�ndan ay�rarak, model ile DTO aras�ndaki d�n��t�rme s�re�lerini basitle�tirir ve geli�tiricinin manuel mapleme i�lemlerinden kaynaklanan hatalar� minimize eder.