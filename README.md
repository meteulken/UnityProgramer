# Unity'deki Temel Hareket Fonksiyonları

## 1. `transform.Translate(direction * speed * Time.deltaTime);`

Nesneyi belirli bir yönde hareket ettirir. `direction` vektörü ile yön belirlenir. `speed` hızı, `Time.deltaTime` ise akıcılık için zaman skalasını temsil eder. Örnek yönler:
- `Vector3.forward`: İleri yönde hareket.
- `Vector3.back`: Geri yönde hareket.
- `Vector3.left`: Sol yönde hareket.
- `Vector3.right`: Sağ yönde hareket.

## 2. `transform.Rotate(axis, angle);`

Nesneyi belirli bir eksende belirtilen açı kadar döndürür. `axis` dönme ekseni, `angle` ise derece cinsinden dönme açısıdır. Örnek eksiler:
- `Vector3.up`: Yatayda dönme (etrafında yukarı eksende dönme).
- `Vector3.down`: Yatayda ters dönme.
- `Vector3.right`: Dikeyde dönme sağa.
- `Vector3.left`: Dikeyde dönme sola.

## 3. `transform.LookAt(Vector3 target);`

Nesneyi belirtilen hedefe yönlendirir. Nesne, hedef noktasını gösteren yöne bakar.

## 4. `Rigidbody.AddForce(Vector3 force);`

Nesneye belirli bir kuvveti uygular. Fizik tabanlı hareket ve etkileşimler için kullanılır.

## 5. `Rigidbody.velocity = new Vector3(x, y, z);`

Nesneye doğrudan bir hız vektörü atar. Fizik tabanlı hareket ve etkileşimlerde kullanışlıdır.

## 6. `transform.position = new Vector3(xRange, transform.position.y, transform.position.z);`

Bu kod parçası, bir nesnenin X koordinatını değiştirirken diğer iki koordinatını değiştirmeksizin nesnenin pozisyonunu güncellemek için kullanılır.
