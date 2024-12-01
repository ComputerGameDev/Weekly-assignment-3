# משחק דו קרב בין קוביות

## **סקירה כללית**
בניית תהליך ליבה של משחק דו קרב יריות בין שתי קוביות, שבו שתי שחקנים מתחרים לירות ולהפגיע זה בזה שלוש פעמים על מנת לנצח.
כל שחקן שולט בקובייה שלו באמצעות מקשים שונים במקלדת, והקוביות יורות לייזרים בכיוון אליו הן פונות.
המשחק כולל מנגנוני תנועה, ירי, זיהוי פגיעות וניהול חיים של כל קובייה עד לקביעת מנצח.

---
## שחקו עכשיו!
לחצו על הקישור הבא כדי לשחק במשחק דרך Itch.io:
[שחקו במשחק ב-Itch.io](https://tomgoz.itch.io/coreprocesstask)

במשחק, שחקן 1 נע באמצעות מקשי החצים ויורה על ידי לחיצה על מקש הרווח, בעוד שחקן 2 נע באמצעות מקשי W, A, S, D ויורה על ידי לחיצה על מקש Tab.
לכל שחקן יש אפשרות לירות (כדורים) בכיוון אליו הקובייה פונה.
מערכת החיים של כל קובייה מצמצמת חיים בכל פגיעה של כדור מהיריב, והשחקן הראשון שפוגע בשלוש פגיעות בקוביית היריב מוכרז כמנצח.

---
## **מבנה הקוד**
**סקריפט תנועה:**
   - מנהל את תנועת הקוביות על בסיס קלט מהמקלדת.
   - מבטיח שהקוביות יפנו לכיוון הנכון תוך כדי תנועה.

**סקריפט ירי (`KeyboardSpawner`):**
   - יוצר כדורים כאשר לחצן הירי נלחץ.
   - הכדורים מקבלים מהירות וכיוון לפי כיוון הקובייה שיורה.

**סקריפט זיהוי פגיעות (`DestroyOnTrigger`):**
   - מזהה פגיעה של כדור בקובייה.
   - מפחית חיים של הקובייה שנפגעה ומשמיד את הכדור.

**מערכת חיים:**
   - מנהלת את מצב החיים של כל שחקן.
   - מעדכנת את ה-UI (TextMeshPro) עם מספר החיים הנותרים.

---
## **הפניות לקוד**
# סקריפטים - הסבר והפניה

---

## **CollisionLogger.cs**
**תיאור:**  
סקריפט זה עוקב אחר התנגשויות בין אובייקטים במשחק ומדפיס ללוג פרטים על ההתנגשויות. הסקריפט נועד לעזור לבדוק ולנתח אילו אובייקטים מתנגשים זה בזה.

**קישור לקוד:** [CollisionLogger.cs](./Assets/Scripts/CollisionLogger.cs)

---

## **DestroyOnTrigger.cs**
**תיאור:**  
סקריפט זה משמיד אובייקט כאשר הוא מתנגש עם אובייקט אחר בעל תג ספציפי. הוא גם מפחית חיים (Health) של השחקן ומעדכן את ה-UI בהתאם. אם כמות החיים יורדת לאפס, השחקן מוסר מהמשחק, והמשחק יכול להסתיים.

**קישור לקוד:** [DestroyOnTrigger.cs](./Assets/Scripts/DestroyOnTrigger.cs)

---

## **KeyboardSmoothMover.cs**
**תיאור:**  
סקריפט זה מנהל את תנועת השחקנים בצורה חלקה באמצעות מקשי המקלדת. הוא מחשב תנועה רציפה על בסיס קלט מהמשתמש ומאפשר חווית משחק חלקה ונוחה יותר.

**קישור לקוד:** [KeyboardSmoothMover.cs](./Assets/Scripts/KeyboardSmoothMover.cs)

---

## **KeyboardSpawner.cs**
**תיאור:**  
סקריפט זה מאפשר לשחקנים לירות כדורים בלחיצת כפתור. הוא מטפל ביצירת הכדורים במיקום הנכון, בכיוון הנכון, ובמהירות שנקבעה מראש. 

**קישור לקוד:** [KeyboardSpawner.cs](./Assets/Scripts/KeyboardSpawner.cs)

---

## **Mover.cs**
**תיאור:**  
סקריפט זה אחראי על תנועת האובייקטים. הוא מאפשר להגדיר מהירות ותנועה בכיוון מסוים לכל אובייקט שמחובר אליו.

**קישור לקוד:** [Mover.cs](./Assets/Scripts/Mover.cs)

---

## **ScreenBounds.cs**
**תיאור:**  
סקריפט זה מגביל את התנועה של האובייקטים כך שהם לא יצאו מגבולות המסך. הוא מחשב את הגבולות לפי מצלמת המשחק ושומר את האובייקטים בגבולות המשחק.

**קישור לקוד:** [ScreenBounds.cs](./Assets/Scripts/ScreenBounds.cs)

