# Unity'deki Temel Hareket Fonksiyonları

### 1. `transform.Translate(direction * speed * Time.deltaTime);`

Nesneyi belirli bir yönde hareket ettirir. `direction` vektörü ile yön belirlenir. `speed` hızı, `Time.deltaTime` ise akıcılık için zaman skalasını temsil eder. Örnek yönler:
- `Vector3.forward`: İleri yönde hareket.
- `Vector3.back`: Geri yönde hareket.
- `Vector3.left`: Sol yönde hareket.
- `Vector3.right`: Sağ yönde hareket.

### 2. `transform.Rotate(axis, angle);`

Nesneyi belirli bir eksende belirtilen açı kadar döndürür. `axis` dönme ekseni, `angle` ise derece cinsinden dönme açısıdır. Örnek eksiler:
- `Vector3.up`: Yatayda dönme (etrafında yukarı eksende dönme).
- `Vector3.down`: Yatayda ters dönme.
- `Vector3.right`: Dikeyde dönme sağa.
- `Vector3.left`: Dikeyde dönme sola.

### 3. `transform.LookAt(Vector3 target);`

Nesneyi belirtilen hedefe yönlendirir. Nesne, hedef noktasını gösteren yöne bakar.

### 4. `Rigidbody.AddForce(Vector3 force);`

Nesneye belirli bir kuvveti uygular. Fizik tabanlı hareket ve etkileşimler için kullanılır.

### 5. `Rigidbody.velocity = new Vector3(x, y, z);`

Nesneye doğrudan bir hız vektörü atar. Fizik tabanlı hareket ve etkileşimlerde kullanışlıdır.

### 6. `transform.position = new Vector3(xRange, transform.position.y, transform.position.z);`

Bu kod parçası, bir nesnenin X koordinatını değiştirirken diğer iki koordinatını değiştirmeksizin nesnenin pozisyonunu güncellemek için kullanılır.

---

# Unity'de Giriş İşlemleri (Input)

Unity'de `Input` sınıfı, klavye, fare, dokunmatik ekran ve diğer giriş cihazlarından alınan verileri yönetmek için kullanılır. Bu sınıf, oyuncu etkileşimlerini algılamak ve bu etkileşimlere tepki vermek için kullanılır.

### 1. `Input.GetAxis` ve `Input.GetAxisRaw`

Bu fonksiyonlar, klavye veya giriş cihazlarından alınan yatay veya dikey giriş değerlerini döndürür. Bu değerler, genellikle karakter veya nesne hareketini kontrol etmek veya kamera açılarını ayarlamak için kullanılır.

- `Input.GetAxis("Horizontal")`: Yatay yönde giriş alır (-1 ile 1 arasında).
- `Input.GetAxis("Vertical")`: Dikey yönde giriş alır (-1 ile 1 arasında).

### 2. `Input.GetKey` ve `Input.GetKeyDown`

Bu fonksiyonlar, belirli bir tuşun basılı olup olmadığını kontrol eder. `GetKeyDown`, tuşun basıldığı anı algılar ve sadece bir kere tetiklenir.

- `Input.GetKey(KeyCode.Space)`: Boşluk tuşunun basılı olup olmadığını kontrol eder.
- `Input.GetKeyDown(KeyCode.W)`: W tuşunun basılma anını algılar.

### 3. `Input.GetMouseButtonDown` ve `Input.GetMouseButton`

Fare tıklamalarını kontrol etmek için kullanılır. `GetMouseButtonDown`, fare düğmesinin basıldığı anı algılar ve sadece bir kere tetiklenir.

- `Input.GetMouseButtonDown(0)`: Sol fare düğmesinin basılma anını algılar.
- `Input.GetMouseButton(1)`: Sağ fare düğmesinin basılı olup olmadığını kontrol eder.

### 4. `Input.mousePosition`

Farenin mevcut pozisyonunu döndürür. Bu değeri kullanarak fare pozisyonuna göre işlemler yapabilirsiniz.

Bu sadece bazı örneklerdir. Unity'nin belgelemesinde daha fazla `Input` fonksiyonunu ve detayını bulabilirsiniz. `Input` sınıfı, oyuncu girişini algılamanız ve oyununuzu interaktif hale getirmeniz için oldukça önemlidir.

---

# Unity'de `Instantiate` Fonksiyonu Kullanımı

`Instantiate` fonksiyonu, Unity'de nesnelerin kopyalarını oluşturmak için kullanılır. Genellikle prefab'ların (ön tanımlı nesne şablonları) sahneye yerleştirilmesi veya çoğaltılması gerektiğinde kullanılır.

## Kullanım

```csharp
GameObject newObject = Instantiate(prefab, position, rotation);

prefab: Kopyalanacak nesnenin prefab'ı.
position: Oluşturulan kopyanın konumu.
rotation: Oluşturulan kopyanın rotasyonu.
