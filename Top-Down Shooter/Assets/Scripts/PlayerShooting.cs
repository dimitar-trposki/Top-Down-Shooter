    using UnityEngine;

    public class PlayerShooting : MonoBehaviour
    {
        public GameObject bulletPrefab;
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }

        private void Shoot()
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            // Ignore collision with the player
            Physics.IgnoreCollision(bullet.GetComponent<Collider>(), GetComponent<Collider>());

            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);
            
            // GameObject bullet = Instantiate(bulletPrefab);
            //
            // bullet.transform.position = transform.position;
            //
            // bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);
        }
    }