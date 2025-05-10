using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace mdpOdev2
{
    public static class Collision
    {


        public static bool pointSquareCollision(Point point, Square square)
        {
            double minX = square.M.X - square.Edge / 2.0;
            double maxX = square.M.X + square.Edge / 2.0;
            double minY = square.M.Y - square.Edge / 2.0;
            double maxY = square.M.Y + square.Edge / 2.0;

            if (point.X >= minX && point.X <= maxX && point.Y >= minY && point.Y <= maxY)
                return true; // Nokta karenin içinde         
            else
                return false; // Nokta kare dışında

        }

        public static bool pointCircleCollision(Point point, Circle circle)
        {
            double d = Math.Sqrt(Math.Pow((point.X - circle.M.X), 2) + Math.Pow((point.Y - circle.M.Y), 2));

            if (d <= (circle.R / 2))
                return true; // Nokta çemberin içinde
            else
                return false; // Nokta Çemberin dışında
        }

        public static bool rectangleRectangleCollision(RectangleClass rectangle1, RectangleClass rectangle2)
        {
            double minX1 = rectangle1.M.X - (rectangle1.Width / 2);
            double maxX1 = rectangle1.M.X + (rectangle1.Width / 2);
            double minY1 = rectangle1.M.Y - (rectangle1.Height / 2);
            double maxY1 = rectangle1.M.Y + (rectangle1.Height / 2);

            double minX2 = rectangle2.M.X - (rectangle2.Width / 2);
            double maxX2 = rectangle2.M.X + (rectangle2.Width / 2);
            double minY2 = rectangle2.M.Y - (rectangle2.Height / 2);
            double maxY2 = rectangle2.M.Y + (rectangle2.Height / 2);

            if (minX1 < maxX2 && maxX1 > minX2 && minY1 < maxY2 && maxY1 > minY2)
                return true; // dikdörtgenler çarpışıyor
            else
                return false; // dikdörtgenler çarpışmıyor
        }

        public static bool rectangleCircleCollision(RectangleClass rectangle, Circle circle)
        {

            double circleX = circle.M.X;
            double circleY = circle.M.Y;

            //dikdörtgenlerin kenarlarını bul
            double rectangleMinX = rectangle.M.X - (rectangle.Width / 2);
            double rectangleMaxX = rectangle.M.X + (rectangle.Width / 2);
            double rectangleMinY = rectangle.M.Y - (rectangle.Height / 2);
            double rectangleMaxY = rectangle.M.Y + (rectangle.Height / 2);

            // Çemberin merkezi dikdörtgenin sınırları içinde mi?
            double nearestX = Math.Max(rectangleMinX, Math.Min(circleX, rectangleMaxX));
            double nearestY = Math.Max(rectangleMinY, Math.Min(circleY, rectangleMaxY));

            // Çemberin merkezi ile en yakın nokta arasındaki mesafeyi hesapla
            double d = Math.Sqrt(Math.Pow((nearestX - circleX), 2) + Math.Pow((nearestY - circleY), 2));

            if (d <= (circle.R / 2))
                return true; // dikdörtgen ile çember çarpışıyor 
            else
                return false; // dikdörtgen ile çember çarpışmıyor
        }

        public static bool circleCircleCollision(Circle circle1, Circle circle2)
        {
            // iki daire merkezi arasındaki mesafeyi bul
            float d = (float)Math.Sqrt(Math.Pow((circle1.M.X - circle2.M.X), 2) + Math.Pow((circle2.M.Y - circle1.M.Y), 2));


            if (d <= ((circle1.R / 2) + (circle2.R / 2)))
                return true; // daireler çarpışıyor 
            else
                return false; // daireler çarpışmıyor
        }

        public static bool pointSphereCollision(Point3d point, Sphere sphere)
        {
            float d = (float)Math.Sqrt(Math.Pow((point.X - sphere.M.X), 2) + Math.Pow((point.Y - sphere.M.Y), 2 + Math.Pow((point.Z - sphere.M.Z), 2)));

            if (d <= sphere.R)
                return true; // nokta ve küre çarpışıyor
            else
                return false; // nokta ve daire çarpışmıyor
        }

        public static bool pointRectangleCollision(Point point, RectangleClass rectangle)
        {
            double rectangleMinX = rectangle.M.X - (rectangle.Width / 2);
            double rectangleMaxX = rectangle.M.X + (rectangle.Width / 2);
            double rectangleMinY = rectangle.M.Y - (rectangle.Height / 2);
            double rectangleMaxY = rectangle.M.Y + (rectangle.Height / 2);

            if (point.X >= rectangleMinX && point.X <= rectangleMaxX && point.Y >= rectangleMinY && point.Y <= rectangleMaxY)
                return true;
            else
                return false;
        }

        // nokta silindir çarpışması
        public static bool pointCylinderCollision(Point3d point, Cylinder cylinder)
        {
            double cylinderMinX = cylinder.M.X - (cylinder.R / 2);
            double cylinderMaxX = cylinder.M.X + (cylinder.R / 2);
            double cylinderMinY = cylinder.M.Y - (cylinder.H / 2);
            double cylinderMaxY = cylinder.M.Y + (cylinder.H / 2);
            double cylinderMinZ = cylinder.M.Z - (cylinder.R / 2);
            double cylinderMaxZ = cylinder.M.Z + (cylinder.R / 2);

            if (point.X >= cylinderMinX && point.X <= cylinderMaxX &&
                point.Y >= cylinderMinY && point.Y <= cylinderMaxY &&
                point.Z >= cylinderMinZ && point.Z <= cylinderMaxZ)
                return true;
            else
                return false;
        }

        // silindir silindir çarpışması
        public static bool cylinderCylinderCollision(Cylinder cylinder1, Cylinder cylinder2)
        {
            double minX1 = cylinder1.M.X - (cylinder1.R / 2);
            double maxX1 = cylinder1.M.X + (cylinder1.R / 2);
            double minY1 = cylinder1.M.Y - (cylinder1.H / 2);
            double maxY1 = cylinder1.M.Y + (cylinder1.H / 2);
            double minZ1 = cylinder1.M.Z - (cylinder1.R / 2);
            double maxZ1 = cylinder1.M.Z + (cylinder1.R / 2);


            double minX2 = cylinder2.M.X - (cylinder2.R / 2);
            double maxX2 = cylinder2.M.X + (cylinder2.R / 2);
            double minY2 = cylinder2.M.Y - (cylinder2.H / 2);
            double maxY2 = cylinder2.M.Y + (cylinder2.H / 2);
            double minZ2 = cylinder2.M.Z - (cylinder2.R / 2);
            double maxZ2 = cylinder2.M.Z + (cylinder2.R / 2);

            if (minX1 <= maxX2 && maxX1 >= minX2 && minY1 <= maxY2 && maxY1 >= minY2 && minZ1 <= maxZ2 && maxZ1 >= minZ2)
                return true;
            else
                return false;

        }


        // küre küre
        public static bool sphereSphereCollision(Sphere sphere1, Sphere sphere2)
        {
            float d = (float)Math.Sqrt(Math.Pow((sphere1.M.X - sphere2.M.X), 2) + Math.Pow((sphere2.M.Y - sphere1.M.Y), 2) + Math.Pow((sphere1.M.Z - sphere2.M.Z), 2));

            if (d < ((sphere1.R / 2) + (sphere2.R / 2)))
                return true;
            else
                return false;
        }


        // küre silindir
        public static bool sphereCylinderCollision(Sphere sphere, Cylinder cylinder)
        {
            double closestX = Math.Max(cylinder.M.X - (cylinder.R / 2), Math.Min(sphere.M.X, cylinder.M.X + (cylinder.R / 2)));
            double closestY = Math.Max(cylinder.M.Y - (cylinder.H / 2), Math.Min(sphere.M.Y, cylinder.M.Y + (cylinder.H / 2)));
            double closestZ = Math.Max(cylinder.M.Z - (cylinder.R / 2), Math.Min(sphere.M.Z, cylinder.M.Z + (cylinder.R / 2)));

            double distance = Math.Sqrt(Math.Pow(closestX - sphere.M.X, 2) + Math.Pow(closestY - sphere.M.Y, 2) + Math.Pow(closestZ - sphere.M.Z, 2));

            if (distance < sphere.R)
            {
                return true; // Çarpışma varsa true döndür
            }
            else
            {
                return false; // Çarpışma yoksa false döndür
            }
        }


        // yüzey küre
        public static bool surfaceSphereCollision(Surface surface, Sphere sphere)
        {
            double minX = surface.M.X - (surface.Width / 2);
            double maxX = surface.M.X + (surface.Width / 2);
            double minZ = surface.M.Z - (surface.Depth / 2);
            double maxZ = surface.M.Z + (surface.Depth / 2);

            // Kürenin yüzeyin x ve z düzlemleri arasında mı olduğunu kontrol et
            bool withinXBounds = sphere.M.X >= minX && sphere.M.X <= maxX;
            bool withinZBounds = sphere.M.Z >= minZ && sphere.M.Z <= maxZ;

            // Eğer küre yüzeyin içindeki x ve z sınırları içinde ise, yüzeye temas ediyor demektir.
            if (withinXBounds && withinZBounds)
            {
                // Kürenin merkeziyle yüzeyin merkezi arasındaki mesafeyi hesapla
                double distanceX = Math.Abs(sphere.M.X - surface.M.X);
                double distanceZ = Math.Abs(sphere.M.Z - surface.M.Z);

                // Yüzeyin yarı genişliği ve kürenin yarıçapını toplam uzaklıkla karşılaştır
                if (distanceX <= surface.Width / 2 + sphere.R && distanceZ <= surface.Depth / 2 + sphere.R)
                {
                    // Eğer toplam mesafe, yüzeyin yarı genişliği ve kürenin yarıçapından küçük veya eşitse,
                    // küre yüzeye temas ediyor demektir.
                    return true;
                }
                else
                    return false;
            }

            // Yukarıdaki koşullar sağlanmazsa, küre yüzeye temas etmiyor demektir.
            else
                return false;
        }


        // yüzey dikdörtgen prizma
        public static bool surfacePrismCollision(Surface surface, Prism prism)
        {
            int prismMinX = prism.M.X - (prism.Width / 2);
            int prismMaxX = prism.M.X + (prism.Width / 2);
            int prismMinY = prism.M.Y - (prism.Height / 2);
            int prismMaxY = prism.M.Y + (prism.Height / 2);
            int prismMinZ = prism.M.Z - (prism.Depth / 2);
            int prismMaxZ = prism.M.Z + (prism.Depth / 2);

            int surfaceMinX = surface.M.X - (surface.Width / 2);
            int surfaceMaxX = surface.M.X + (surface.Width / 2);
            int surfaceMinZ = surface.M.Z - (surface.Depth / 2);
            int surfaceMaxZ = surface.M.Z + (surface.Depth / 2);

            bool collisionX = prismMinX <= surfaceMaxX && prismMaxX >= surfaceMinX;
            bool collisionZ = prismMinZ <= surfaceMaxZ && prismMaxZ >= surfaceMinZ;

            if (collisionX && collisionZ)
                return true;
            else
                return false;
        }

        // yüzey silindir 
        public static bool surfaceCylinderCollision(Surface surface, Cylinder cylinder)
        {
            int surfaceMinX = surface.M.X - (surface.Width / 2);
            int surfaceMaxX = surface.M.X + (surface.Width / 2);
            int surfaceMinZ = surface.M.Z - (surface.Depth / 2);
            int surfaceMaxZ = surface.M.Z + (surface.Depth / 2);


            int cylinderMinY = cylinder.M.Y - (cylinder.H / 2);
            int cylinderMaxY = cylinder.M.Y + (cylinder.H / 2);
            int cylinderMinX = cylinder.M.X - (cylinder.R / 2);
            int cylinderMaxX = cylinder.M.X + (cylinder.R / 2);
            int cylinderMinZ = cylinder.M.Z - (cylinder.R / 2);
            int cylinderMaxZ = cylinder.M.Z + (cylinder.R / 2);

            bool collisionX = cylinderMinX <= surfaceMaxX && cylinderMaxX >= surfaceMinX;
            bool collisionZ = cylinderMinZ <= surfaceMaxZ && cylinderMaxZ >= surfaceMinZ;

            if (collisionX && collisionZ)
                return true;
            else
                return false;
        }


        // kare dikdörtgen prizma
        public static bool squarePrismCollision(Square square, Prism prism)
        {
            // Karenin koordinatlarını hesapla
            int squareMinX = square.M.X - (square.Edge / 2);
            int squareMaxX = square.M.X + (square.Edge / 2);
            int squareMinY = square.M.Y - (square.Edge / 2);
            int squareMaxY = square.M.Y + (square.Edge / 2);

            // Dikdörtgen prizmanın koordinatlarını hesapla
            int prismMinX = prism.M.X - (prism.Width / 2);
            int prismMaxX = prism.M.X + (prism.Width / 2);
            int prismMinY = prism.M.Y - (prism.Height / 2);
            int prismMaxY = prism.M.Y + (prism.Height / 2);
            int prismMinZ = prism.M.Z - (prism.Depth / 2);
            int prismMaxZ = prism.M.Z + (prism.Depth / 2);

            // Çarpışma kontrolü
            bool collisionX = squareMinX < prismMaxX && squareMaxX > prismMinX;
            bool collisionY = squareMinY < prismMaxY && squareMaxY > prismMinY;

            if (collisionX && collisionY)
                return true;
            else
                return false;

        }
        // diktörtgen przima dikdörtgen przima 
        public static bool prismPrismCollision(Prism prism1, Prism prism2)
        {
            int prism1MinX = prism1.M.X - (prism1.Width / 2);
            int prism1MaxX = prism1.M.X + (prism1.Width / 2);
            int prism1MinY = prism1.M.Y - (prism1.Height / 2);
            int prism1MaxY = prism1.M.Y + (prism1.Height / 2);
            int prism1MinZ = prism1.M.Z - (prism1.Depth / 2);
            int prism1MaxZ = prism1.M.Z + (prism1.Depth / 2);

            int prism2MinX = prism2.M.X - (prism2.Width / 2);
            int prism2MaxX = prism2.M.X + (prism2.Width / 2);
            int prism2MinY = prism2.M.Y - (prism2.Height / 2);
            int prism2MaxY = prism2.M.Y + (prism2.Height / 2);
            int prism2MinZ = prism2.M.Z - (prism2.Depth / 2);
            int prism2MaxZ = prism2.M.Z + (prism2.Depth / 2);

            bool collisionX = prism1MinX < prism2MaxX && prism1MaxX > prism2MinX;
            bool collisionY = prism1MinY < prism2MaxY && prism1MaxY > prism2MinY;
            bool collisionZ = prism1MinZ < prism2MaxZ && prism1MaxZ > prism2MinZ;

            if (collisionX && collisionY && collisionZ)
                return true;
            else
                return false;
        }
    }

}